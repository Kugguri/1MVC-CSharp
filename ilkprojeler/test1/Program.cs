using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace test1
{
    public class Program
    {
        //DEPENDENCÝES
        /*
           ESKÝDEN REFESANCE KISMIMIZ VARDIR O ARTIK .NET CORE DEPENDENCÝES OLARAK KARÞIMIZA ÇIKIYOR.
        BÜTÜN KÜTÜPHANELER FRAMEWORKLER VB UYGULAMADA BAÐIMLILIK OLARAK ADLANIRILIYOR.

         */




        //asp.netcore da ayný zamanda bir konsol uygulamasýdýr.
        public static void Main(string[] args)
        {
             //Create hos builder kýsmýndaki metodu derle ve çalýþtýr

            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>

            //hostun ayaða kalýdrabilmesi için gerekli þeylere startup üzerinden ulaþ ve kullan.

            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
