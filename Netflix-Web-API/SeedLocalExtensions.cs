using BusinessLogic.Entities;
using BusinessLogic.Interfaces;
using DataAccess.Data;

namespace Netflix_Web_API
{
    public static class SeedLocalExtensions
    {
        public static void SeedingData(this WebApplication app)
        {
            using (var scope = app.Services.CreateScope())
            {
                var repository = scope.ServiceProvider.GetRequiredService<IRepository<Selection>>();
               
            }
        }
    }
}
