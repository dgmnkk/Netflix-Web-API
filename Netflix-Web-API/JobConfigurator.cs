using BusinessLogic.Interfaces;
using Hangfire;

namespace Netflix_Web_API
{
    public class JobConfigurator
    {
        public static void AddJobs()
        {
            RemoveExpiredTokensJob();
        }
        public static void RemoveExpiredTokensJob()
        {
            RecurringJob.AddOrUpdate<IAccountsService>(
                nameof(RemoveExpiredTokensJob),
                (service) => service.RemoveExpiredRefreshTokens(),
                Cron.Weekly(DayOfWeek.Monday, 3));
        }
    }
}
