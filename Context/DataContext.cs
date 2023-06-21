using CategoryCrud.Model;
using Microsoft.EntityFrameworkCore;

namespace CategoryCrud.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Category> Categories { get; set; }
    }
}
