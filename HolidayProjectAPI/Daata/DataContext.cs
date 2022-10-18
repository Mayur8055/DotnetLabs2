using Microsoft.EntityFrameworkCore;
using System.Data.Entity;

namespace HolidayProjectAPI.Daata
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        
            public DbSet<Product>products { get; set; }
    
    }
}
