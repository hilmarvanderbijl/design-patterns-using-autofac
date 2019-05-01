using System;
using System.Collections.Generic;
using StrategyPattern.Services.Generic;

namespace StrategyPattern.Services
{
    public class CustomerServiceWithoutStrategy : IService<Customer>
    {
        private readonly List<Customer> _customers = new List<Customer>();

        public void Add(Customer customer)
        {
            _customers.Add(customer);

            switch (customer.PreferredContactMethod)
            {
                case ContactMethod.Email:
                    Console.WriteLine($"You Were added! (email to {customer.Email})");
                    break;
                case ContactMethod.TextMessage:
                    Console.WriteLine($"You Were added! (text message to {customer.Phone})");
                    break;
                case ContactMethod.CarrierPigeon:
                    Console.WriteLine("You Were added! (carrier pigeon dispatched!)");
                    break;
                default:
                    Console.WriteLine("No means of contacting the customer");
                    break;
            }
        }
    }
}