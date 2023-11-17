using APIForCRUD.Data;
using APIForCRUD.Models.Domain;
using APIForCRUD.Repository.Interface;

namespace APIForCRUD.Repository.Implementation
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext dbContext;

        public CategoryRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<Category> CreateAsync(Category category)
        {
            await dbContext.Categorys.AddAsync(category);
            await dbContext.SaveChangesAsync();

            return category;
        }
    }
}
