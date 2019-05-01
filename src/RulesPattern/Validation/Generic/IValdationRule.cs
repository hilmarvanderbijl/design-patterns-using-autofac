using System.Collections.Generic;

namespace RulesPattern.Validation.Generic
{
    public interface IValdationRule<T>
    {
        IEnumerable<string> GetValidationErrors(T itemToValidate);
    }
}