using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assignment_1_Navneet_4531978
{
  public class Product_Context:DbContext
    {
        public DbSet<Product>? Product { get; set; }
        public DbSet<Category>? Category { get; set; }


        // database connection info 
        // in the form of connection string
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(LocalDB)\MSSQLLocalDB;Database=ProductCF_DB;Trusted_Connection=True;MultipleActiveResultSets=true;");
        }
    }
}
