using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using System.IO;

namespace OcelotWebGW
{
    public class Program
    {
        public static void Main(string[] args)
        {
            webHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder webHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args).ConfigureAppConfiguration((host, config) =>
            {
                config.AddJsonFile(Path.Combine("Config", "configuration.json"));
            }).UseStartup<Startup>();
    }
}
