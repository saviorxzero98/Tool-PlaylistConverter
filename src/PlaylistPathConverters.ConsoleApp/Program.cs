using Microsoft.Extensions.Configuration;

namespace PlaylistPathConverters.ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            var app = new MainApp(GetConfiguration());
            app.Run();
        }


        static IConfiguration GetConfiguration()
        {
            var config = new ConfigurationBuilder().AddJsonFile("appsettings.json",
                                                                optional: true,
                                                                reloadOnChange: true)
                                                   .AddJsonFile("appsettings.development.json",
                                                                optional: true,
                                                                reloadOnChange: true)
                                                   .Build();
            return config;
        }
    }
}
