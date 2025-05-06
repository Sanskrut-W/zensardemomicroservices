using Ocelot.DependencyInjection;
using Ocelot.Middleware;
namespace ApiGetweway
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Configuration.AddJsonFile("Ocelot.json");

            // Add services to the container.
            builder.Services.AddOcelot();
          
            var app = builder.Build();

            // Configure the HTTP request pipeline.

            app.UseOcelot();
            app.Run();
        }
    }
}
