using Microsoft.EntityFrameworkCore;
using WEbApi_One_to_Many_Relational.Dbcontext;
using WEbApi_One_to_Many_Relational.Models;
using WEbApi_One_to_Many_Relational.Repository;
using WEbApi_One_to_Many_Relational.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<TablesDbcontext>(x => x.UseSqlServer(builder.Configuration["DbObject"]));
builder.Services.AddScoped<IDataRepository<State>, StateServices>();
builder.Services.AddScoped<IDataRepository<City>, CityServices>();

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
