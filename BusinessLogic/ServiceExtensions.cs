using AutoMapper;
using BusinessLogic.Interfaces;
using BusinessLogic.Profiles;
using BusinessLogic.Services;
using Microsoft.Extensions.DependencyInjection;
using FluentValidation;

namespace BusinessLogic
{
    public static class ServiceExtensions
    {
        public static void AddAutoMapper(this IServiceCollection services)
        {
            //services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            services.AddSingleton(provider => new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new ApplicationProfile(provider.CreateScope().ServiceProvider.GetService<IFileService>()!));
            }).CreateMapper());
        }

        public static void AddFluentValidators(this IServiceCollection services)
        {
            services.AddValidatorsFromAssemblies(AppDomain.CurrentDomain.GetAssemblies());
        }

            public static void AddCustomServices(this IServiceCollection services)
        {
            services.AddScoped<IMoviesService, MoviesService>();
            services.AddScoped<IAccountsService, AccountsService>();
            services.AddScoped<IJwtService, JwtService>();
            services.AddScoped<IGenresService, GenresServices>();
            services.AddScoped<IFileService, LocalFileService>();
            services.AddScoped<IFileService, AzureFileService>();
            services.AddScoped<ISelectionsService, SelectionsService>();
        }
    }
}
