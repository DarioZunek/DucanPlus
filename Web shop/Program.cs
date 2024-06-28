using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Web_shop.Services;

namespace Web_shop
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDbContext<DucanPlusDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DucanPlusDb")));
            builder.Services.AddSession();
            builder.Services.AddAuthorization();
            builder.Services.AddControllersWithViews();
            builder.Services.AddSingleton<PayPalService>();
            builder.Services.Configure<EmailSettings>(builder.Configuration.GetSection("EmailSettings"));
            builder.Services.AddTransient<EmailService>();

            builder.Services.AddRazorPages();
            var app = builder.Build();

            using (var scope = app.Services.CreateScope())
            {
                var dbContext = scope.ServiceProvider.GetRequiredService<DucanPlusDbContext>();
                dbContext.Database.Migrate();
            }

            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseSession();
            app.UseAuthorization();
            app.MapControllers();
            app.MapRazorPages();

            app.Run();
        }
    }
}
