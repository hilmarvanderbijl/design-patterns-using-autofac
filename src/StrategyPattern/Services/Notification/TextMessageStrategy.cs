using System;

namespace StrategyPattern.Services.Notification
{
    public class TextMessageStrategy : ICustomerNotificationStrategy
    {
        public void NotifyApplicant(Customer customer, string message)
        {
            Console.WriteLine($"{message} (text message to {customer.Phone})");
        }
    }
}