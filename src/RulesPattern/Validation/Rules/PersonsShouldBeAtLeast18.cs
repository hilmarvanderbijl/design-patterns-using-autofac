using System;
using System.Collections.Generic;
using System.Linq;
using RulesPattern.Validation.Generic;

namespace RulesPattern.Validation.Rules
{
    public class PersonsShouldBeAtLeast18 : IValdationRule<Person>
    {
        public IEnumerable<string> GetValidationErrors(Person itemToValidate)
        {
            return itemToValidate.BirthDate.Subtract(DateTime.Now).TotalDays / 365 < 18
                ? new[] { "Person is too young!" }
                : Enumerable.Empty<string>();
        }
    }
}