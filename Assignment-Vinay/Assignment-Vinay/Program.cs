using Azure.Identity;
using BusinessLogicLayer.Repositories;
using BusinessLogicLayer.Services;
using BusinessLogicLayer.ServicesForRepository;
using DataAccessLayer.DbConnectionFolder;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Web;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddMicrosoftIdentityWebApi(builder.Configuration.GetSection("AzureAd"));

//New Key Vault
//var newKeyVaultEndPoint = new Uri($"https://{builder.Configuration["Vinay-New-KeyVault"]}.vault.azure.net/");
//builder.Configuration.AddAzureKeyVault(newKeyVaultEndPoint, new DefaultAzureCredential());


builder.Services.AddControllers();

//Key Vault
var keyVaultEndPoint = new Uri($"https://{builder.Configuration["DbConnectObject"]}.vault.azure.net/");
builder.Configuration.AddAzureKeyVault(keyVaultEndPoint, new DefaultAzureCredential());

builder.Services.AddDbContext<DbContextClass>(x => x.UseSqlServer(builder.Configuration["vinayConnstring"]));
builder.Services.AddTransient<IEnrollmentRepository,EnrollmentServices>();
builder.Services.AddScoped<IStudentRepository,StudentServices>();
builder.Services.AddScoped<ICourseRepository, CourseServices>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "MSAL_Authdemo",
        Version = "v1"
    });
    c.AddSecurityDefinition("oauth2", new OpenApiSecurityScheme
    {
        Type = SecuritySchemeType.OAuth2,
        Flows = new OpenApiOAuthFlows()

        {
            Implicit = new OpenApiOAuthFlow()
            {
                //AuthorizationUrl = new Uri($"https://login.microsoftonline.com/{builder.Configuration["TenentID"]}/oauth2/v2.0/authorize"),
                //TokenUrl = new Uri($"https://login.microsoftonline.com/{builder.Configuration["TenentID"]}/oauth2/v2.0/token"),
                AuthorizationUrl = new Uri("https://login.microsoftonline.com/8f6bd982-92c3-4de0-985d-0e287c55e379/oauth2/v2.0/authorize"),
                TokenUrl = new Uri("https://login.microsoftonline.com/8f6bd982-92c3-4de0-985d-0e287c55e379/oauth2/v2.0/token"),
                Scopes = new Dictionary<string, string>
                {
                        {
                            "api://b2dca548-c0fd-4298-9774-5a8111c34e1c/newUser",
                            "Read files"
                        }
                }
            }
        }
    });

    c.AddSecurityRequirement(new OpenApiSecurityRequirement() {
    {
        new OpenApiSecurityScheme
        {
            Reference = new OpenApiReference
            {
                    Type = ReferenceType.SecurityScheme,
                        Id = "oauth2"
            },
                Scheme = "oauth2",
                Name = "oauth2",
                In = ParameterLocation.Header
        },
        new List < string > ()
    }});
});

var app = builder.Build();

// Configure the HTTP request pipeline.
//if (true)
//{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "AuthDemo v1");
        //c.OAuthClientId(builder.Configuration["ClientID"]);
        //c.OAuthClientSecret(builder.Configuration["ClientSecretID"]);
        c.OAuthClientId("b2dca548-c0fd-4298-9774-5a8111c34e1c");
        c.OAuthClientSecret("mF68Q~fdPFw8U6BF1enSQvYocEOLFpict450YdgH");
        c.OAuthUseBasicAuthenticationWithAccessCodeGrant();
    });
//}

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
