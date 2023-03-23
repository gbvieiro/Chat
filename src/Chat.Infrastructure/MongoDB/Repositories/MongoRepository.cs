using AutoMapper;
using AutoMapper.Extensions.ExpressionMapping;
using Design.IS7.Domain.Entities;
using Design.IS7.Domain.RepositoryInterfaces;
using Design.IS7.Domain.ValueObjects;
using Design.IS7.Infrastructure.MongoDB.Collections;
using MongoDB.Driver;
using System.Linq.Expressions;

namespace Design.IS7.Infrastructure.MongoDB.Repositories
{
    public abstract class MongoRepository<EntityType, DocumentType>
        where EntityType : Entity
        where DocumentType : MongoDocument
    {
        protected IMongoCollection<DocumentType> MongoCollection { get; set; }
        protected IMapper Mapper { get; set; }

        public MongoRepository(
            IMapper mapper,
            IRepositoryConnection repository,
            string collectionName)
        {
            var connection = repository.GetConnection();
            var mongoClientSettings = new MongoClientSettings()
            {
                UseTls = connection.UseTls,
                ApplicationName = connection.ApplicationName
            };

            List<MongoServerAddress> servers = new();
            connection.ConnectionServerAddresses.ForEach(x =>
            {
                servers.Add(
                    new MongoServerAddress(x.Host, x.Port)
                );
            });
            mongoClientSettings.Servers = servers.ToArray();

            if (connection.ConnectionServerAddresses.Count > 1)
            {
                mongoClientSettings.ReplicaSetName = connection.ReplicaSetName;
                mongoClientSettings.DirectConnection = false;
            }
            else
            {
                mongoClientSettings.DirectConnection = true;
            }

            if (connection.ConnectionCredentials != null)
                mongoClientSettings.Credential =
                    MongoCredential.CreateCredential(
                        connection.ConnectionCredentials.DatabaseName,
                        connection.ConnectionCredentials.Username,
                        connection.ConnectionCredentials.Password
                    );

            MongoClient mongoClient = new(mongoClientSettings);
            var mongoDatabase = mongoClient.GetDatabase(connection.DataBaseName);

            MongoCollection = mongoDatabase.GetCollection<DocumentType>(collectionName);
            Mapper = mapper;
        }

        public void SetMockItems(List<EntityType> documents)
        {
            documents.Clear();
            throw new Exception("Set Mock Itens its only available on test projects:");
        }

        public async Task<List<EntityType>> GetAsync() =>
            Mapper.Map<List<EntityType>>(await MongoCollection.Find(_ => true).ToListAsync());

        public async Task<EntityType?> GetAsync(string id) =>
            Mapper.Map<EntityType>(await MongoCollection.Find(x => x.Id == id).FirstOrDefaultAsync());

        public async Task<List<EntityType>> GetAsync(
            Expression<Func<EntityType, bool>> filterExpression
        )
        {
            var filterDocumentExpression =
                Mapper.MapExpression<Expression<Func<DocumentType, bool>>>(
                    filterExpression
                );

            var itens = await MongoCollection.Find(filterDocumentExpression).ToListAsync();
            return Mapper.Map<List<EntityType>>(itens);
        }
        public async Task<EntityType> GetOneAsync(
            Expression<Func<EntityType, bool>> filterExpression
        )
        {
            var filterDocumentExpression =
                Mapper.MapExpression<Expression<Func<DocumentType, bool>>>(
                    filterExpression
                );

            var itens = await MongoCollection.Find(filterDocumentExpression).FirstOrDefaultAsync();
            return Mapper.Map<EntityType>(itens);
        }

        public async Task<PaginatedResult<EntityType>> GetAsync(
            Expression<Func<EntityType, bool>> filterExpression,
            int skip,
            int take
        )
        {
            var filterDocumentExpression =
                Mapper.MapExpression<Expression<Func<DocumentType, bool>>>(
                    filterExpression
                );

            var query = MongoCollection.Find(filterDocumentExpression);

            var data = Mapper.Map<List<EntityType>>(
                await query.Skip(skip).Limit(take).ToListAsync()
            );

            var total = await query.CountDocumentsAsync();

            return PaginatedResult<EntityType>.Create(data, total);
        }

        public async Task<List<EntityType>> GetAsync(
            Expression<Func<EntityType, bool>> filterExpression,
            Expression<Func<EntityType, object>> orderExpression,
            bool sortByDescending)
        {
            var filterDocumentExpression =
                Mapper.MapExpression<Expression<Func<DocumentType, bool>>>(
                    filterExpression
                );

            var orderDocumentExpression =
                Mapper.MapExpression<Expression<Func<DocumentType, object>>>(
                    orderExpression
                );

            var query = MongoCollection.Find(filterDocumentExpression);
            if (sortByDescending)
                query = query.SortByDescending(orderDocumentExpression);
            else
                query = query.SortBy(orderDocumentExpression);

            return Mapper.Map<List<EntityType>>(
                await query.ToListAsync()
            );
        }

        public async Task<PaginatedResult<EntityType>> GetAsync(
            Expression<Func<EntityType, bool>> filterExpression,
            int skip,
            int take,
            Expression<Func<EntityType, object>> orderExpression,
            bool sortByDescending
        )
        {
            var filterDocumentExpression =
                Mapper.MapExpression<Expression<Func<DocumentType, bool>>>(
                    filterExpression
                );

            var orderDocumentExpression =
                Mapper.MapExpression<Expression<Func<DocumentType, object>>>(
                    orderExpression
                );

            var query = MongoCollection.Find(filterDocumentExpression);
            if (sortByDescending)
                query = query.SortByDescending(orderDocumentExpression);
            else
                query = query.SortBy(orderDocumentExpression);

            // Count has to be done before applying `.Skip` and `.Limit` as those will mutate the query object.
            var count = await query.CountDocumentsAsync();

            var data =
                Mapper.Map<List<EntityType>>(
                    await query.Skip(skip)
                        .Limit(take)
                        .ToListAsync()
                );


            return PaginatedResult<EntityType>.Create(data, count);
        }

        public async Task<List<EntityType>> GetAsync(
            Expression<Func<DocumentType, bool>> filter,
            int skip, int take) =>
                Mapper.Map<List<EntityType>>(
                    await MongoCollection.Find(filter)
                        .Skip(skip).Limit(take).ToListAsync());

        public async Task<string> CreateAsync(EntityType newEntity)
        {
            var newDocument = Mapper.Map<DocumentType>(newEntity);
            var newId = newDocument.GenerateId();
            await MongoCollection.InsertOneAsync(newDocument);
            return newId;
        }

        public async Task UpdateAsync(string id, EntityType updatedEntity) =>
            await MongoCollection.ReplaceOneAsync(
                x => x.Id == id, Mapper.Map<DocumentType>(updatedEntity));

        public async Task RemoveAsync(string id) =>
            await MongoCollection.DeleteOneAsync(x => x.Id == id);
    }
}