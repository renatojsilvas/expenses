using Expenses.Webapi.Contracts.Base;

namespace Expenses.Webapi.Contracts
{
    public class NewExpenseOutput : OutputBase
    {
        public Guid ExpenseId { get; set; }
        public DateTime CreationAt { get; set; }
        public Guid CreatedBy { get; set; }
        public string Description { get; set; } = string.Empty;
        public decimal Value { get; set; }
    }
}