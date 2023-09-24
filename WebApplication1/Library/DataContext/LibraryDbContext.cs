using Library.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Library.DataContext
{
    public class LibraryDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-AIBH7MI\\SQLEXPRESS; initial catalog=Library; integrated Security=true");
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
    }
}
