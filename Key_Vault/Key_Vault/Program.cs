using Azure.Identity;
using Key_Vault.DbConnection;
using Key_Vault.Models;
using Key_Vault.Repository;
using Key_Vault.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

//var KeyVaultEndpoint = new Uri($"https://{builder.Configuration["DbConnect"]}.vault.azure.net/");
var KeyVaultEndpoint = new Uri($"https://{builder.Configuration["DbConnect"]}.vault.azure.net/");
builder.Configuration.AddAzureKeyVault(KeyVaultEndpoint, new DefaultAzureCredential());


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<CustomerDbContext>(x => x.UseSqlServer(builder.Configuration["vinayConnstring"]));
builder.Services.AddScoped<IDataRepository<Customer>, CustomerServices>();

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
