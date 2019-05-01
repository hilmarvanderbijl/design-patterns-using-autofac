using System;

namespace StrategyPattern.Services.Notification
{
    public class EmailStrategy : ICustomerNotificationStrategy
    {
        public void NotifyApplicant(Customer customer, string message)
        {
            Console.WriteLine($"{message} (email to {customer.Email})");
        }
    }
}