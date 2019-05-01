using System.Collections.Generic;
using System.Linq;
using RulesPattern.Validation.Generic;

namespace RulesPattern.Validation.Rules
{
    public class PersonShouldHaveName : IValdationRule<Person>
    {
        public IEnumerable<string> GetValidationErrors(Person itemToValidate)
        {
            return string.IsNullOrEmpty(itemToValidate.Name)
                ? new[] {"Name is mandatory."}
                : Enumerable.Empty<string>();
        }
    }
}
