using AspBetSample.DataBase;
using AspBetSample.DataBase.Entities;
using AspNetSample.Business.ServicesImplementations;
using AspNetSample.Core.Abstractions;
using AspNetSample.Data.Abstractions;
using AspNetSample.Data.Abstractions.Repositories;
using AspNetSample.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Serilog;
using Serilog.Events;

namespace AspNetSample.WebAPI
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


            builder.Services.AddControllers();

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

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(options =>
            {
                options.IncludeXmlComments(builder.Configuration["XmlDoc"]);
            } );

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}