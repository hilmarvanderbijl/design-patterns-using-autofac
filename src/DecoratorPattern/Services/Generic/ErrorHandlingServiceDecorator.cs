using System;

namespace DecoratorPattern.Services.Generic
{
    public class ErrorHandlingServiceDecorator<T> : IService<T>
    {
        private readonly IService<T> _decoratedService;

        public ErrorHandlingServiceDecorator(IService<T> decoratedService)
        {
            _decoratedService = decoratedService;
        }

        public void Add(T itemToAdd)
        {
            try
            {
                _decoratedService.Add(itemToAdd);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred when adding an item: {ex.Message}");
            }
        }
    }
}