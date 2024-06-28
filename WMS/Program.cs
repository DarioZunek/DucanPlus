using Microsoft.EntityFrameworkCore;

namespace WMS
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var optionsBuilder = new DbContextOptionsBuilder<DucanPlusDbContext>();
            string connectionString = "Server=DESKTOP-J4BLD8F;Database=DucanPlus;User Id=sa;Password=lozinka00;";
            optionsBuilder.UseSqlServer(connectionString);

            using (var context = new DucanPlusDbContext(optionsBuilder.Options))
            {
                context.Database.Migrate();
            }

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new PocetnaForm());

        }
    }
}