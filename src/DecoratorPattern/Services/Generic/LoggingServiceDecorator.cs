using System;

namespace DecoratorPattern.Services.Generic
{
    public class LoggingServiceDecorator<T> : IService<T>
    {
        private readonly IService<T> _decoratedService;

        public LoggingServiceDecorator(IService<T> decoratedService)
        {
            _decoratedService = decoratedService;
        }

        public void Add(T itemToAdd)
        {
            Console.WriteLine($"Trying to add {typeof(T).Name}...");

            _decoratedService.Add(itemToAdd);

            Console.WriteLine($"Successfully added {typeof(T).Name}!");
        }
    }
}