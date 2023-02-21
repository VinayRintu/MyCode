using BLL.Repository;
using BLL.Services;
using DAL.Models;
using DAL.TablesDbContext;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<DbcontextClass>(x => x.UseSqlServer(builder.Configuration["DbConnection"]));
builder.Services.AddScoped<IDataRepository<Students>, StudentsServices>();
builder.Services.AddScoped<IDataRepository<Courses>, CourseServices>();
builder.Services.AddScoped<IDataRepository<Enrollments>, EnrollmentServics>();

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
