using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace ISkillsMyApp.Models
{
    public class ISkillsContext : DbContext
    {
        //public ISkillsContext()
        //{
        //    Database.Connection.ConnectionString = "Server=tcp:bookstore1.database.windows.net,1433;Data Source=bookstore1.database.windows.net;Initial Catalog=BookStore;Persist Security Info=False;User ID=test1;Password=Welcome1;Pooling=False;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        //}
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Categories> Categories { get; set; }

    }
}