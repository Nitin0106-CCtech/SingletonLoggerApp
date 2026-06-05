using SingletonLoggerApp.Services;
using SingletonLoggerApp.Singleton;

namespace SingletonLoggerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            UserService userService = new UserService();
            PaymentService paymentService = new PaymentService();

            userService.RegisterUser("Tin Tin");

            paymentService.ProcessPayment(1500);

            Logger logger1 = Logger.Instance;
            Logger logger2 = Logger.Instance;

            Console.WriteLine();
            Console.WriteLine("Checking Singleton:");

            if (logger1 == logger2)
            {
                Console.WriteLine("Both references point to the same Logger instance.");
            }
            else
            {
                Console.WriteLine("Different instances exist.");
            }
        }
    }
}
