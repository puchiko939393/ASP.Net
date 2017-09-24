using System.Data.Entity;

namespace WingtipToys.Models
{
    public class ProductContext : DbContext {
        /*  ProductContext.....
         *  
         * Connecting to Database and Take the database info 
         Database table: Catrgories
                         Products
                         */
        public ProductContext() : base("WingtipToys")
        {}
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; } 
    }
}