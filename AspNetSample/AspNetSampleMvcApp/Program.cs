using AspBetSample.DataBase;
using AspBetSample.DataBase.Entities;
using AspNetSample.Business.ServicesImplementations;
using AspNetSample.Core.Abstractions;
using AspNetSample.Data.Abstractions;
using AspNetSample.Data.Abstractions.Repositories;
using AspNetSample.Data.Repositories;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Routing.Constraints;
using Microsoft.EntityFrameworkCore;
using Serilog;
using Serilog.Events;

namespace AspNetSampleMvcApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Host.UseSerilog((ctx, lc) =>
                lc.WriteTo.File(
                    @"C:\Users\AlexiMinor\Desktop\New folder (2)\logs\data.log",
                    LogEventLevel.Information)
                    .WriteTo.Console(LogEventLevel.Verbose));

            // Add services to the container.
            builder.Services.AddControllersWithViews(options =>
            {
                //    options.Filters.Add<CustomActionFilter>();
                //    //alternative options
                //    options.Filters.Add(typeof(CustomActionFilter));
                //    options.Filters.Add(new CustomActionFilter());
            });

            builder.Services
                .AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(options =>
                {
                    options.ExpireTimeSpan = TimeSpan.FromHours(1);
                    options.LoginPath = new PathString(@"/Account/Login");
                    options.LogoutPath = new PathString(@"/Account/Logout");
                    options.AccessDeniedPath = new PathString(@"/Account/Login");
                });

            var connectionString = builder.Configuration.GetConnectionString("Default");
            //"Server=DESKTOP-11O0AN1\\SQLSERVER2019;Database=GoodNewsAggregatorDataBase;Trusted_Connection=True;";

            builder.Services.AddDbContext<GoodNewsAggregatorContext>(
                optionsBuilder => optionsBuilder.UseSqlServer(connectionString));

            builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            builder.Services.AddScoped<IArticleService, ArticleService>();
            builder.Services.AddScoped<ISourceService, SourceService>();
            builder.Services.AddScoped<IUserService, UserService>();
            builder.Services.AddScoped<IRoleService, RoleService>();
            builder.Services.AddScoped<IAdditionalArticleRepository, ArticleGenericRepository>();
            builder.Services.AddScoped<IRepository<Source>, Repository<Source>>();
            builder.Services.AddScoped<IRepository<User>, Repository<User>>();
            builder.Services.AddScoped<IRepository<Role>, Repository<Role>>();
            builder.Services.AddScoped<IArticleRepository, ArticleRepository>();
            builder.Services.AddScoped<ISourceRepository, SourceRepository>();
            builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
            //builder.Services.AddScoped<ArticleCheckerActionFilter>();

            builder.Configuration.AddJsonFile("secrets.json");
            //builder.Configuration.AddTextFile("somepath");

            
            var app = builder.Build();


            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            
            app.UseRouting();

            app.UseAuthentication(); // Set HttpContext.User
            app.UseAuthorization(); 


            //app.MapControllerRoute(
            //    name: "default1",
            //    pattern: "{action}/{controller}");

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.MapControllerRoute(
                name: "article",
                pattern: "{page:int=0}/{action}/{controller}",
                defaults: new { controller = "Article", action = "Index" },
                constraints: new { page = new IntRouteConstraint() } /*if no (:int?) or similar in pattern string*/);

            //var str = string.Format("{0}/{1}/{2}", 1, 3, 5);


            app.Run();
        }
    }
}