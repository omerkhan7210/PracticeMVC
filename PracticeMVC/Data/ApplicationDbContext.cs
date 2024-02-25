using Microsoft.EntityFrameworkCore;
using PracticeMVC.Models;

namespace PracticeMVC.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<CategoryModel> Categories { get; set; }
    }
}
