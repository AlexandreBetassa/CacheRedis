using RedisP1.Contracts.v1;
using RedisP1.Database.Data.v1;
using RedisP1.Services.Contracts.v1;
using RedisP1.Utils.v1;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IDatabase, Database>();

builder.Services.RegisterAllTypes<IService>(new[] { typeof(Program).Assembly });
builder.Services.RegisterAllTypes<IRepository>(new[] { typeof(Program).Assembly });

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
