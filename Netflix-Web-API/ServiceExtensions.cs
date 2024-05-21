using BusinessLogic.Entities;
using BusinessLogic.Helpers;
using Hangfire;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.IdentityModel.Tokens;
using Netflix_Web_API.Requirements;
using System.Text;

namespace Netflix_Web_API
{
    public static class Policies
    {
        public const string PREMIUM_CLIENT = "PremiumClient";
        public const string ADULT = "Adult";
    }
    public static class ServiceExtensions
    {
        public static void AddHangfire(this IServiceCollection services, string connectionString)
        {
            services.AddHangfire(config =>
            {
                config.UseSqlServerStorage(connectionString);
            });

            services.AddHangfireServer();
        }
        public static void AddRequirements(this IServiceCollection services)
        {
            services.AddSingleton<IAuthorizationHandler, MinimumAgeHandler>();
        }
        public static void AddJWT(this IServiceCollection services, IConfiguration configuration)
        {
            var jwtOpts = configuration.GetSection(nameof(JwtOptions)).Get<JwtOptions>()!;

            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(o =>
                {
                    o.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuer = true,
                        ValidateAudience = false,
                        ValidateLifetime = true,
                        ValidateIssuerSigningKey = true,
                        ValidIssuer = jwtOpts.Issuer,
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtOpts.Key)),
                        ClockSkew = TimeSpan.Zero
                    };
                });

            services.AddAuthorization(options =>
            {
                options.AddPolicy(Policies.PREMIUM_CLIENT, policy =>
                    policy.RequireClaim("ClientType", ClientType.Premium.ToString()));
            });

            services.AddAuthorization(options =>
            {
                options.AddPolicy(Policies.ADULT, policy =>
                    policy.Requirements.Add(new MinimumAgeRequirement(18)));
            });
        }
    }
}
