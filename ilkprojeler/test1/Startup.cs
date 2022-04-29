using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace test1
{
    public class Startup
    {
        //TEMEL WEB UYGULAMASINDA MVS APÝ VB GÝBÝ YAKLAÞIMLARIMIZI KONFÝGURE ETTÝÐÝMÝZ DOSYADIR.
        //ÝKÝ FARKLI ANA YAPILANDIRMAMIZ VAR CONFG.SERVÝCE-CONFÝGURE

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            //UYGULAMADA KULLANACAÐIMIZ SERVÝSLERÝN EKLENDÝÐÝ METODDUR.
            //SERVÝS:ASP.NETCORE MODÜLER YAPIDAN BAHSETMÝÞTÝK(PARÇA BÜTÜN ÝLÝÞKÝSÝ)
            //SERVÝSLER BELÝRLÝ ÝÞLERE ODAKLANMIÞ O ÝÞLERÝN SORUMLULUÐUNU ALMIÞ YAPILARDIR 
            //MESELA ÖDEME PAKETÝNÝ BUNA ÖRNEK VEREBÝLÝRÝZ.
          

            services.AddRazorPages();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //UYGULAMADA MÝDDLEWWARE DEDÝÐÝMÝZ  ARA YAZILIMLAR BULUNMAKTADIR.
            //BURADA ONLARI KULLANIYORUZ


            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();
            //gelen isteðimizin rotasýdýr (url)
            app.UseEndpoints(endpoints =>
            {  
                //**RAZOR**
                //MVCYE ÖZEL VÝEWDE UI TABANLI ÇALIÞMALAR GERÇEKLEÞTÝREBÝLMEM ÝÇÝN 
                //GELÝÞTÝRÝLMÝÞ BÝR TEKNOLOJÝ

                endpoints.MapRazorPages();
            });
        }
    }
}
