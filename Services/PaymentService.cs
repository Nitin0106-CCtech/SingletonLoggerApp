using SingletonLoggerApp.Singleton;

namespace SingletonLoggerApp.Services
{
    public class PaymentService
    {
        public void ProcessPayment(double amount)
        {
            Logger.Instance.Log($"Payment of ₹{amount} processed.");
        }
    }
}
