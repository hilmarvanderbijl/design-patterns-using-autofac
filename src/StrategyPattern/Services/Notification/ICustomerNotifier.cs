namespace StrategyPattern.Services.Notification
{
    public interface ICustomerNotifier
    {
        void NotifyApplicantUsingPreferredContactMethod(Customer customer, string message);
    }
}