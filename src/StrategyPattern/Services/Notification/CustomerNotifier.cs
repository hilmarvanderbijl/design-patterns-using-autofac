using System;
using Autofac.Features.Indexed;

namespace StrategyPattern.Services.Notification
{
    public class CustomerNotifier : ICustomerNotifier
    {
        private readonly IIndex<ContactMethod, ICustomerNotificationStrategy> _notificationStrategies;

        public CustomerNotifier(IIndex<ContactMethod, ICustomerNotificationStrategy> notificationStrategies)
        {
            _notificationStrategies = notificationStrategies;
        }

        public void NotifyApplicantUsingPreferredContactMethod(Customer customer, string message)
        {
            if (_notificationStrategies.TryGetValue(customer.PreferredContactMethod, out var strategy))
            {
                strategy.NotifyApplicant(customer, message);
                return;
            }

            Console.WriteLine("No means of contacting the customer");
        }
    }
}