using Microsoft.EntityFrameworkCore;
using RedisP1.Contracts.v1;
using RedisP1.Database.v1;
using RedisP1.Models.v1;
using RedisP1.Repositories.v1;
using RedisP1.Services.Contracts.v1;
using RedisP1.Services.v1;
using RedisP1.Utils.v1;
using StackExchange.Redis;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped(typeof(IDatabase<>), typeof(Database<>));
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped(typeof(IService<>), typeof(Service<>));

builder.Services.AddStackExchangeRedisCache(opt =>
{
    opt.InstanceName = "redis";
    opt.Configuration = "localhost: 6379";
});

builder.Services.AddDbContext<AppDbContext>(opt => opt.UseSqlServer(builder.Configuration["ConnectionString:DefaultConnection"]));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
