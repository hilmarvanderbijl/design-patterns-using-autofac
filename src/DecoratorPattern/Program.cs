using System;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using DecoratorPattern.Services;
using DecoratorPattern.Services.Generic;
using Microsoft.Extensions.DependencyInjection;

namespace DecoratorPattern
{
    class Program
    {
        private static IServiceProvider _serviceProvider;

        static void Main(string[] args)
        {
            RegisterServices();

            var personService = _serviceProvider.GetService<IService<Person>>();

            personService.Add(new Person
            {
                Name = "John"
            });

            personService.Add(new Person
            {
                Name = string.Empty
            });

            Console.ReadLine();
        }

        private static void RegisterServices()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<UndecoratedPersonService>().As<IService<Person>>();

            builder.RegisterType<PersonService>().As<IService<Person>>();
            builder.RegisterDecorator<PersonValidationServiceDecorator, IService<Person>>();
            
            builder.RegisterGenericDecorator(typeof(LoggingServiceDecorator<>), typeof(IService<>));
            builder.RegisterGenericDecorator(typeof(TimingServiceDecorator<>), typeof(IService<>));
            builder.RegisterGenericDecorator(typeof(ErrorHandlingServiceDecorator<>), typeof(IService<>));

            _serviceProvider = new AutofacServiceProvider(builder.Build());
        }
    }
}
