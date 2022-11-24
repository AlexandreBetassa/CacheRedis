using Microsoft.EntityFrameworkCore;
using RedisP1.Contracts.v1;
using RedisP1.Database.Repositories.v1;
using RedisP1.Database.v1;
using RedisP1.Models.v1;
using RedisP1.Services.Contracts.v1;
using RedisP1.Services.v1;
using RedisP1.Utils.v1;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped(typeof(IDatabase<>), typeof(Database<>));
builder.Services.AddScoped<IService<Pix>, PixService>();
builder.Services.AddScoped<IService<CreditCard>, CreditCardService>();
builder.Services.AddScoped<IService<DebitCard>, DebitCardService>();


builder.Services.AddScoped<IRepository<DebitCard>, DebitCardRepository>();
builder.Services.AddScoped<IRepository<CreditCard>, CreditCardRepository>();
builder.Services.AddScoped<IRepository<Pix>, PixRepository>();

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
