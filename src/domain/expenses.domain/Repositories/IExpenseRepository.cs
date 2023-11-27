using Expenses.Domain.Entities;

namespace Expenses.Domain.Repositories
{
    public interface IExpenseRepository
    {
        Task<IEnumerable<Expense>> GetExpensesAsync(CancellationToken cancellationToken);
        Task<Expense> GetExpenseByIdAsync(Guid id, CancellationToken cancellationToken);
        Task<IEnumerable<Expense>> GetExpensesByUserAsync(Guid userId, CancellationToken cancellationToken);
        Task<IEnumerable<Expense>> GetExpensesByUserByPeriodAsync(Guid userId, DateTime initialDate, DateTime endDate, CancellationToken cancellationToken);
        Task AddExpenseAsync(Expense expense, CancellationToken cancellationToken);
        Task UpdateExpenseAsync(Guid id, Expense expense, CancellationToken cancellationToken);
        Task DeleteExpenseAsync(Guid id, CancellationToken cancellationToken);
    }
}
