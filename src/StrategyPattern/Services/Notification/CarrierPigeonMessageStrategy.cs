using System;

namespace StrategyPattern.Services.Notification
{
    public class CarrierPigeonMessageStrategy : ICustomerNotificationStrategy
    {
        public void NotifyApplicant(Customer customer, string message)
        {
            Console.WriteLine($"{message} (carrier pigeon dispatched!)");
        }
    }
}