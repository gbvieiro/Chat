using Chat.API.IOC;
using Chat.Application.Hubs;
using Chat.Application.Mappers;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

// Add Swagger
builder.Services.AddSwaggerGen(s =>
{
    s?.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Chat API",
        Version = "v1"
    });
});

// Configure CORS
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(builder =>
        builder
           .AllowAnyMethod()
           .AllowAnyHeader()
           .SetIsOriginAllowed(
               origin => new Uri(origin).Host == "localhost"
           )
           .AllowCredentials()

    );
});

// Add IOC Services
builder.Services.AddAppServices();

// Configure Auto Mapper
AppMapper.Configure(builder.Services);

// Add Signal R
builder.Services.AddSignalR();

var app = builder.Build();

app.UseCors();
app.UseSwagger();
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.UseSwaggerUI();
app.MapHub<ChatHub>("/ChatHub");
app.Run();