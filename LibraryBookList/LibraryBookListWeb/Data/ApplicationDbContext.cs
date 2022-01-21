using LibraryBookListWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryBookListWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options)
        {

        }

        public DbSet<Book> Books { get; set; }
    }
}
