using Flunt.Validations;

namespace Todo.Domain.Commands.Contracts
{
    public interface ICommands : IValidatable
    {
        bool Validate();
    }
}