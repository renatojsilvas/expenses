using Expenses.Domain.Base;
using Expenses.Domain.Exceptions;

namespace Expenses.Domain.Entities
{
    public sealed class User : Entity
    {
        public User CreateNewUser(Guid id, DateTime createdAt, string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new DomainException("Nome não pode ser vazio");
            }

            return new User(id, createdAt, name);
        }

        private User(Guid id, DateTime createdAt, string name)
            : base(id, createdAt)
        {
            Name = name;
        }

        public string Name { get; private set; }
    }
}
