using System.ComponentModel.DataAnnotations;
using DecoratorPattern.Services.Generic;

namespace DecoratorPattern.Services
{
    public class PersonValidationServiceDecorator : IService<Person>
    {
        private readonly IService<Person> _decoratedService;

        public PersonValidationServiceDecorator(IService<Person> decoratedService)
        {
            _decoratedService = decoratedService;
        }

        public void Add(Person itemToAdd)
        {
            if (string.IsNullOrEmpty(itemToAdd.Name))
            {
                throw new ValidationException("Name should not be empty");
            }

            _decoratedService.Add(itemToAdd);
        }
    }
}