using System.Collections.Generic;
using StrategyPattern.Services.Generic;
using StrategyPattern.Services.Notification;

namespace StrategyPattern.Services
{
    public class CustomerService : IService<Customer>
    {
        private readonly List<Customer> _customers = new List<Customer>();

        private readonly ICustomerNotifier _customerNotifier;

        public CustomerService(ICustomerNotifier customerNotifier)
        {
            _customerNotifier = customerNotifier;
        }

        public void Add(Customer customer)
        {
            _customers.Add(customer);
            _customerNotifier.NotifyApplicantUsingPreferredContactMethod(customer, "You were added!");
        }
    }
}