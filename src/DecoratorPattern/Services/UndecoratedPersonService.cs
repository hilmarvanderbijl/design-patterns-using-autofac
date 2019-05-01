using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using DecoratorPattern.Services.Generic;

namespace DecoratorPattern.Services
{
    public class UndecoratedPersonService : IService<Person>
    {
        private readonly List<Person> _people = new List<Person>();

        public void Add(Person itemToAdd)
        {
            var stopwatch = new Stopwatch();

            Console.WriteLine("Trying to add Person...");

            try
            {
                if (string.IsNullOrEmpty(itemToAdd.Name))
                {
                    throw new ValidationException("Name should not be empty");
                }

                _people.Add(itemToAdd);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred when adding an item: {ex.Message}");
                return;
            }

            Console.WriteLine("Successfully added Person...");

            Console.WriteLine($"Adding Person took {stopwatch.ElapsedMilliseconds}ms.");
        }
    }
}