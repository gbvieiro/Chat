using Design.IS7.Infrastructure.MongoDB.Collections;
using System.Linq.Expressions;

namespace Design.IS7.Infrastructure.Models
{
    public class SortExpression<DocumentType> where DocumentType : MongoDocument
    {
        public SortExpression(
            Expression<Func<DocumentType, object>> expression,
            SortType sortType)
        {
            Expression = expression;
            SortType = sortType;
        }

        public Expression<Func<DocumentType, object>> Expression { get; private set; }
        public SortType SortType { get; private set; }

        public static SortExpression<DocumentType> Create(Expression<Func<DocumentType, object>> expression, bool descending = false) =>
            new(expression, descending ? SortType.Descending : SortType.Ascending);
    }
}