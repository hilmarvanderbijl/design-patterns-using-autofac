using System;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using RulesPattern.Validation.Generic;
using Microsoft.Extensions.DependencyInjection;
using RulesPattern.Validation;
using RulesPattern.Validation.Rules;

namespace RulesPattern
{
    class Program
    {
        private static IServiceProvider _serviceProvider;

        static void Main(string[] args)
        {
            RegisterServices();

            var validator = _serviceProvider.GetService<IValidator<Person>>();

            var validationErrors = validator.GetValidationErrors(new Person
            {
                Name = null,
                BirthDate = new DateTime(2000, 1, 1)
            });

            foreach (var validationError in validationErrors)
            {
                Console.WriteLine(validationError);
            }

            Console.ReadLine();
        }

        private static void RegisterServices()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<PersonValidator>().As<IValidator<Person>>();

            //builder.RegisterGeneric(typeof(Validator<>)).As(typeof(IValidator<>));
            //builder.RegisterType<PersonShouldHaveName>().As<IValdationRule<Person>>();
            //builder.RegisterType<PersonShouldNotHaveAVeryLongName>().As<IValdationRule<Person>>();
            //builder.RegisterType<PersonsShouldBeAtLeast18>().As<IValdationRule<Person>>();
            //builder.RegisterType<PersonShouldNotBeJohn>().As<IValdationRule<Person>>();

            _serviceProvider = new AutofacServiceProvider(builder.Build());
        }
    }
}
