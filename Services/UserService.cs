using SingletonLoggerApp.Singleton;

namespace SingletonLoggerApp.Services
{
    public class UserService
    {
        public void RegisterUser(string username)
        {
            Logger.Instance.Log($"User '{username}' registered.");
        }
    }
}
