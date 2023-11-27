using Expenses.Domain.Base;
using Expenses.Domain.Exceptions;

namespace Expenses.Domain.Entities
{
    public sealed class Expense : Entity
    {
        public static Expense CreateNewExpense(
            Guid id,
            DateTime createdAt,
            decimal value,
            string description,
            DateTime date,
            Guid categoryId,
            Guid userId)
        {
            if (value <= 0m)
            {
                throw new DomainException("Valor da despesa deve ser maior que zero");
            }

            if (string.IsNullOrEmpty(description))
            {
                throw new DomainException("Descrição não pode ser vazia");
            }

            return new Expense(id, createdAt, value, description, date, categoryId, userId);
        }

        private Expense(
            Guid id,
            DateTime createdAt,
            decimal value,
            string description,
            DateTime date,
            Guid categoryId,
            Guid userId)
            : base(id, createdAt)
        {
            Value = value;
            Description = description;
            Date = date;
            CategoryId = categoryId;
            UserId = userId;
        }

        public decimal Value { get; private set; }
        public string Description { get; private set; }
        public DateTime Date { get; private set; }
        public Guid CategoryId { get; private set; }
        public Guid UserId { get; private set; }
    }
}