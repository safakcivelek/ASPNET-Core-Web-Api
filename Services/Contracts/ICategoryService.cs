using Entities.Models;

namespace Services.Contracts
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> GetAllCategoriesAsync(bool trackChanges);
        Task<Category> GetOnCategoryByIdAsync(int id, bool trackChanges);
    }
}