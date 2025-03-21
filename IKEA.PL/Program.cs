using Microsoft.EntityFrameworkCore;

namespace IKEA.PL
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);


            // Add services to the container.

            #region congigue sercies
            builder.Services.AddControllersWithViews();

            //builder.Services.AddDbContext<ApplicationDbCOntext>(options =>
            //{
            //    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
            //});


            //builder.Services.AddScoped<ApplicationDbCOntext>();            
            //builder.Services.AddScoped<DbContextOptions<ApplicationDbCOntext>>((service) =>
            //{
            //    var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbCOntext>();
            //    optionsBuilder.UseSqlServer("Server=.;Database=IKEA_G02;Trusted_Connection=true;Trutservercertificate=true");
            //    var options = optionsBuilder.Options;
            //    return options;
            //});
            #endregion           
            //builder.Services.AddDbContext<ApplicationDbCOntext>(options =>
            //{
            //    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
            //});           
            var app = builder.Build();

            #region cofigure Ppelines (MiddleWares)

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

            //app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            #endregion

            app.Run();
        }
    }
}
