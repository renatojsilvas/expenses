using Expenses.Domain.Base;
using Expenses.Domain.Exceptions;

namespace Expenses.Domain.Entities
{
    public sealed class Category : Entity
    {
        public Category CreateNewCategory(Guid id, DateTime createdAt, string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new DomainException("Nome não pode ser vazio");
            }

            return new Category(id, createdAt, name);
        }

        private Category(Guid id, DateTime createdAt, string name)
            : base(id, createdAt)
        {
            Name = name;
        }

        public string Name { get; private set; }
    }
}