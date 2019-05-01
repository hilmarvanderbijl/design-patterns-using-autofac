using System.Collections.Generic;
using System.Linq;

namespace RulesPattern.Validation.Generic
{
    public class Validator<T> : IValidator<T>
    {
        private readonly List<IValdationRule<T>> _rules;

        public Validator(IEnumerable<IValdationRule<T>> rules)
        {
            _rules = rules.ToList();
        }

        public IReadOnlyCollection<string> GetValidationErrors(T itemToValidate)
        {
            return _rules
                .SelectMany(r => r.GetValidationErrors(itemToValidate))
                .ToList();
        }
    }
}