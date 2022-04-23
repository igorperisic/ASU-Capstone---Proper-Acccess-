using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using System.Collections;
using System.Net;
using System.Text;
using RestSharp;
using RestSharp.Authenticators;
using System.Threading;

namespace CapstoneWebApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Thread thread = new Thread(RunGetJson);
            thread.Start();
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });

        //TODO: add await at some point
        public static async void RunGetJson()
        {

            ProcessStartInfo ProcessInfo;
            Process Process;

            //Use /C to hide windows
            //Use /K to show windows (will spam new cmd windows every 30 seconds)
            ProcessInfo = new ProcessStartInfo("cmd.exe", "/C " + "python3 GetJson.py");
            ProcessInfo.CreateNoWindow = true;

            ProcessInfo.UseShellExecute = false;

            while (true)
            {
                Process = Process.Start(ProcessInfo);
                System.Threading.Thread.Sleep(30000);
            }   
        }
    }
}
