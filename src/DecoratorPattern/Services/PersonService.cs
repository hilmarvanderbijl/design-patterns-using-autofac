using System.Collections.Generic;
using DecoratorPattern.Services.Generic;

namespace DecoratorPattern.Services
{
    public class PersonService : IService<Person>
    {
        private readonly List<Person> _people = new List<Person>();

        public void Add(Person itemToAdd)
        {
            _people.Add(itemToAdd);
        }
    }
}