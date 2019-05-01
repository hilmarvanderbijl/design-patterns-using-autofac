using System.Collections.Generic;

namespace RulesPattern.Validation.Generic
{
    public interface IValidator<T>
    {
        IReadOnlyCollection<string> GetValidationErrors(T itemToValidate);
    }
}