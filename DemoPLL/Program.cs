using Demo.BuisnessLogic.Services;
using Demo.DataAccess.Data.Contexts;
using Demo.DataAccess.Repositories.DepartmentRepositorys;
using Microsoft.EntityFrameworkCore;
using Microsoft.Win32;

namespace DemoPLL
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            #region Add services to the container.

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            #region . Register To Service in DI Container
            //. Register To Service in DI Container
            //builder.Services.AddScoped<ApplictionDbContext>();  2. Register To Service in DI Container
            builder.Services.AddDbContext<ApplictionDbContext>(options =>
            {
                //options.UseSqlServer(builder.Configuration["ConnectionStrings.DefaultConnection"]);
                //options.UseSqlServer(builder.Configuration.GetSection("ConnectionStrings")["DefaultConnection"])
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));


            });

            //builder.Services.AddScoped<DepartmentService>();
            builder.Services.AddScoped<IDepartmentRepository, DepartmentRepository>();
            //builder.Services.AddScoped<IDepartmentRepository,MocDepartmentRepository>();
            // register To Service in DI Container
            builder.Services.AddScoped<IDepartmentService, DepartmentService>();
            #endregion

            #endregion
            var app = builder.Build();

            #region Configure the HTTP request pipeline
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

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
            #endregion
        }
    }
}
