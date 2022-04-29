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
        //DEPENDENC�ES
        /*
           ESK�DEN REFESANCE KISMIMIZ VARDIR O ARTIK .NET CORE DEPENDENC�ES OLARAK KAR�IMIZA �IKIYOR.
        B�T�N K�T�PHANELER FRAMEWORKLER VB UYGULAMADA BA�IMLILIK OLARAK ADLANIRILIYOR.

         */




        //asp.netcore da ayn� zamanda bir konsol uygulamas�d�r.
        public static void Main(string[] args)
        {
             //Create hos builder k�sm�ndaki metodu derle ve �al��t�r

            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>

            //hostun aya�a kal�drabilmesi i�in gerekli �eylere startup �zerinden ula� ve kullan.

            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
