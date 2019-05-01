using System;
using System.Diagnostics;

namespace DecoratorPattern.Services.Generic
{
    public class TimingServiceDecorator<T> : IService<T>
    {
        private readonly IService<T> _decoratedService;

        public TimingServiceDecorator(IService<T> decoratedService)
        {
            _decoratedService = decoratedService;
        }

        public void Add(T itemToAdd)
        {
            var stopwatch = new Stopwatch();

            _decoratedService.Add(itemToAdd);

            Console.WriteLine($"Adding Person took {stopwatch.ElapsedMilliseconds}ms.");
        }
    }
}