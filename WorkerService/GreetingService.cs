using BackgroundService_api_gateway.Model;
using BackgroundService_api_gateway.Service;

namespace BackgroundService_api_gateway.WorkerService
{
    public class GreetingService : BackgroundService
    {
        private readonly ILogger<GreetingService> _logger;
        public GreetingService(ILogger<GreetingService> logger)
        {
            _logger = logger;
        }
        protected override async Task ExecuteAsync(CancellationToken cancellationToken)
        {
            while(!cancellationToken.IsCancellationRequested)
            {
                UserService userService = new ();
                // _logger.LogInformation("My worker service running at : {time}", DateTimeOffset.Now);
                foreach(User user in userService.GetUsers())
                {
                    SmsService smsService = new ();
                    smsService.SendSms(user);
                }
                await Task.Delay(1000, cancellationToken);
            }
        }
    }
}