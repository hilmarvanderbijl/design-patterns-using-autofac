using System;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using StrategyPattern.Services.Generic;
using Microsoft.Extensions.DependencyInjection;
using StrategyPattern.Services;
using StrategyPattern.Services.Notification;

namespace StrategyPattern
{
    class Program
    {
        private static IServiceProvider _serviceProvider;

        static void Main(string[] args)
        {
            RegisterServices();

            var customerService = _serviceProvider.GetService<IService<Customer>>();

            var customer = new Customer
            {
                PreferredContactMethod = ContactMethod.Email,
                Email = "info@hilmarvanderbijl.nl",
                Phone = "911"
            };

            customerService.Add(customer);

            Console.ReadLine();
        }

        private static void RegisterServices()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<CustomerServiceWithoutStrategy>().As<IService<Customer>>();

            //builder.RegisterType<CustomerService>().As<IService<Customer>>();
            //builder.RegisterType<CustomerNotifier>().As<ICustomerNotifier>();
            //builder.RegisterType<EmailStrategy>().Keyed<ICustomerNotificationStrategy>(ContactMethod.Email);
            //builder.RegisterType<TextMessageStrategy>().Keyed<ICustomerNotificationStrategy>(ContactMethod.TextMessage);
            //builder.RegisterType<CarrierPigeonMessageStrategy>().Keyed<ICustomerNotificationStrategy>(ContactMethod.CarrierPigeon);

            _serviceProvider = new AutofacServiceProvider(builder.Build());
        }
    }
}
