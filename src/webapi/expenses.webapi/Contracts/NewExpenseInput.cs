namespace Expenses.Webapi.Contracts
{
    public record NewExpenseInput
    {
        public Guid UserId { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; } = string.Empty;
        public decimal Value { get; set; }
        public Guid CategoryId { get; set; }
    }
}