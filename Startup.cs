using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebbAppEcommerce.Repository;
using WebbAppEcommerce.Repository.impl;
using WebbAppEcommerce.Service;
using WebbAppEcommerce.Service.impl;
using WebEcommerce.Data;

namespace WebbAppEcommerce
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddDistributedMemoryCache();

            services.AddSession();
            services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddEntityFrameworkSqlServer()
                .AddDbContext<BancoContext>(o => o.UseSqlServer(Configuration.GetConnectionString("DataBase")));

            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<IPedidoRepository, PedidoRepository>();
            services.AddScoped<IPedidoItemRepository, PedidoItemRepository>();
            services.AddScoped<IClienteRepository, ClienteRepository>();

            services.AddScoped<IProdutoService, ProdutoService>();
            services.AddScoped<IPedidoItemService, PedidoItemService>();
            services.AddScoped<IClienteService, ClienteService>();
            services.AddScoped<IPedidoService, PedidoService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();
            app.UseSession();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Pedidos}/{action=Carrossel}/{codigo?}");
            });
        }
    }
}
