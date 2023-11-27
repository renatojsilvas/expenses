using Expenses.Domain.Entities;

namespace Expenses.Domain.Repositories
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> GetCategoriesAsync(CancellationToken cancellationToken);
        Task<Category> GetCategoryByIdAsync(Guid id, CancellationToken cancellationToken);
        Task AddCategoryAsync(Category category, CancellationToken cancellationToken);
        Task UpdateCategoryAsync(Guid id, Category category, CancellationToken cancellationToken);
        Task DeleteCategoryAsync(Guid id, CancellationToken cancellationToken);
    }
}
