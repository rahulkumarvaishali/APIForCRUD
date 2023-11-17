using APIForCRUD.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace APIForCRUD.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<Category> Categorys { get; set; }
    }
}
