using System.Collections.Generic;
using System.Linq;
using RulesPattern.Validation.Generic;

namespace RulesPattern.Validation.Rules
{
    public class PersonShouldNotHaveAVeryLongName : IValdationRule<Person>
    {
        public IEnumerable<string> GetValidationErrors(Person itemToValidate)
        {
            return itemToValidate.Name != null && itemToValidate.Name.Length > 20
                ? new[] { "Name is too long." }
                : Enumerable.Empty<string>();
        }
    }
}