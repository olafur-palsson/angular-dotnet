using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace backend
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // MQTTMessageLogic.TestMQTTConnectionWithPublicBroker();
            // This starts the Kestrel Server
            BuildWebHost(args).Run();
            // Environment.Exit(0);
        }


        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .UseUrls("http://*:5050")
                .Build();
    }
}
