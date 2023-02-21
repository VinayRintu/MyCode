using Azure.Identity;
using Key_Vault.Models;
using Microsoft.Azure.Services.AppAuthentication;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace Key_Vault.DbConnection
{
    public class CustomerDbContext : DbContext
    {
        public CustomerDbContext(DbContextOptions options):base(options) 
        {
            var conn = (SqlConnection)this.Database.GetDbConnection();
            conn.AccessToken = (new AzureServiceTokenProvider()).GetAccessTokenAsync("https://database.windows.net/").Result;
        }

        public DbSet<Customer> Customers1 { get; set; }
    }
}
