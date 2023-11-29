using BackgroundService_api_gateway.Model;

namespace BackgroundService_api_gateway.Service
{
    public class SmsService
    {
        public void SendSms(User user)
        {
            Console.WriteLine($"Hello! {user.Name}, we have send your salary for the month to your mail {user.Email}");
        }
    }
}