using System;
using System.Collections.Generic;
using System.Linq;
using RulesPattern.Validation.Generic;

namespace RulesPattern.Validation.Rules
{
    public class PersonShouldNotBeJohn : IValdationRule<Person>
    {
        public IEnumerable<string> GetValidationErrors(Person itemToValidate)
        {
            return "john".Equals(itemToValidate.Name, StringComparison.InvariantCultureIgnoreCase)
                ? new[] {"Go away John!"}
                : Enumerable.Empty<string>();
        }
    }
}
