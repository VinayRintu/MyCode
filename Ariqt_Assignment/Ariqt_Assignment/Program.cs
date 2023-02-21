using Azure.Identity;
using BusinessLogicLayer.Repositories;
using BusinessLogicLayer.Services;
using DataAccessLayer.DbContextFolder;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//Key Vault
var keyVaultEndpoint = new Uri($"https://{builder.Configuration["DbConnectionObject"]}.vault.azure.net/");
builder.Configuration.AddAzureKeyVault(keyVaultEndpoint, new DefaultAzureCredential());

builder.Services.AddControllers();

builder.Services.AddDbContext<DbContextClass>(x => x.UseSqlServer(builder.Configuration["NewSecret"]));
builder.Services.AddScoped<IStudentRepository, StudentServices>();
builder.Services.AddScoped<ICourseRepository, courseServices>();
builder.Services.AddTransient<IEnrollmentRepository,EnrollmentServices>();
builder.Services.AddEndpointsApiExplorer();
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
