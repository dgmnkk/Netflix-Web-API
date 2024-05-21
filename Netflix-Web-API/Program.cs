using BusinessLogic;
using DataAccess;
using Hangfire;
using Netflix_Web_API;
using Netflix_Web_API.Helpers;

public class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        var connStr = builder.Configuration.GetConnectionString("LocalDb")!;

        // Add services to the container.

        builder.Services.AddControllers();
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();
        builder.Services.AddJWT(builder.Configuration);
        builder.Services.AddRequirements();
        builder.Services.AddDbContext(connStr);
        builder.Services.AddIdentity();

        builder.Services.AddRepositories();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();
        builder.Services.AddAutoMapper();
        builder.Services.AddFluentValidators();

        builder.Services.AddCustomServices();
        builder.Services.AddHangfire(connStr);

        var app = builder.Build();

        using (var scope = app.Services.CreateScope())
        {
            scope.ServiceProvider.SeedRoles().Wait();
            scope.ServiceProvider.SeedAdmin().Wait();
        }

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();
        app.UseStaticFiles();

        app.UseMiddleware<GlobalErrorHandler>();

        app.UseCors(options =>
        {
            options.WithOrigins("http://localhost:4200", "http://localhost:3000")
                .AllowAnyMethod()
                .AllowAnyHeader();
        });

        app.UseAuthorization();

        app.UseHangfireDashboard("/dash");
        JobConfigurator.AddJobs();
        app.MapControllers();

        app.Run();
    }
}