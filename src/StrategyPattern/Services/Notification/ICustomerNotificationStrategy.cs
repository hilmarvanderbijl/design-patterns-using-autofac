namespace StrategyPattern.Services.Notification
{
    public interface ICustomerNotificationStrategy
    {
        void NotifyApplicant(Customer customer, string message);
    }
}