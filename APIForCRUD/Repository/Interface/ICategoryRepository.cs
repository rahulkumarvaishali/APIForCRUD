using APIForCRUD.Models.Domain;

namespace APIForCRUD.Repository.Interface
{
    public interface ICategoryRepository
    {
        Task<Category> CreateAsync(Category category);
    }
}
