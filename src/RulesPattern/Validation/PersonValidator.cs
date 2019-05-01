using System;
using System.Collections.Generic;
using RulesPattern.Validation.Generic;

namespace RulesPattern.Validation
{
    public class PersonValidator : IValidator<Person>
    {
        public IReadOnlyCollection<string> GetValidationErrors(Person itemToValidate)
        {
            var errors = new List<string>();

            if (string.IsNullOrEmpty(itemToValidate.Name))
            {
                errors.Add("Name is mandatory.");
            }
            else if (itemToValidate.Name.Length > 20)
            {
                errors.Add("Name is too long.");
            }

            if ("john".Equals(itemToValidate.Name, StringComparison.InvariantCultureIgnoreCase))
            {
                errors.Add("Go away John!");
            }

            if (itemToValidate.BirthDate.Subtract(DateTime.Now).TotalDays / 365 < 18)
            {
                errors.Add("Person is too young!");
            }

            return errors;
        }
    }
}