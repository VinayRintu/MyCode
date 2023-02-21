using Microsoft.EntityFrameworkCore;
using System.Data;
using WebApi_With_Ef_CodeFirst.Database_Connection;
using WebApi_With_Ef_CodeFirst.Models;
using WebApi_With_Ef_CodeFirst.Repository;
using WebApi_With_Ef_CodeFirst.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddDbContext<EmployeeContext>(x => x.UseSqlServer(builder.Configuration["EmployeeDB"]));
builder.Services.AddScoped<IDataRepository<Employee>, EmployeeServices>();
//builder.Services.AddDbContext<EmployeeContext>(x => x.UseSqlServer(Configuration["ConnectionString:EmployeeDB"]));
builder.Services.AddSwaggerGen();

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
