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
        //TEMEL WEB UYGULAMASINDA MVS AP� VB G�B� YAKLA�IMLARIMIZI KONF�GURE ETT���M�Z DOSYADIR.
        //�K� FARKLI ANA YAPILANDIRMAMIZ VAR CONFG.SERV�CE-CONF�GURE

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            //UYGULAMADA KULLANACA�IMIZ SERV�SLER�N EKLEND��� METODDUR.
            //SERV�S:ASP.NETCORE MOD�LER YAPIDAN BAHSETM��T�K(PAR�A B�T�N �L��K�S�)
            //SERV�SLER BEL�RL� ��LERE ODAKLANMI� O ��LER�N SORUMLULU�UNU ALMI� YAPILARDIR 
            //MESELA �DEME PAKET�N� BUNA �RNEK VEREB�L�R�Z.
          

            services.AddRazorPages();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //UYGULAMADA M�DDLEWWARE DED���M�Z  ARA YAZILIMLAR BULUNMAKTADIR.
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
            //gelen iste�imizin rotas�d�r (url)
            app.UseEndpoints(endpoints =>
            {  
                //**RAZOR**
                //MVCYE �ZEL V�EWDE UI TABANLI �ALI�MALAR GER�EKLE�T�REB�LMEM ���N 
                //GEL��T�R�LM�� B�R TEKNOLOJ�

                endpoints.MapRazorPages();
            });
        }
    }
}
