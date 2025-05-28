using IndieGameDevelopmentHubApp.Models;
using Microsoft.EntityFrameworkCore;

namespace IndieGameDevelopmentHubApp
{
    internal static class Program
    {
        public static void print<T>(T s)//FOR FASTER PRINTING
        {
            System.Diagnostics.Debug.WriteLine(s);
        }
        public class User
        {
            public decimal UserID;
            public UserTypeEnum UserType;
        }
        public enum UserTypeEnum : byte
        {
            NULL = 0,
            Developer = 1,
            Player = 2,
            Tester = 3,
        }//WORK forr email length: 14
        public static User LoggedInUser;

        public static DbContextOptionsBuilder<IndieGameDevelopmentHubContext> optionsBuilder = new DbContextOptionsBuilder<IndieGameDevelopmentHubContext>();

        public const string connectionString = "Server=localhost;Database=IndieGameDevelopmentHub;Trusted_Connection=True;TrustServerCertificate=True;";
        public const string DateFormat = "yyyy-MM-dd HH:mm:ss";

        public static void SQLAccess(Action<IndieGameDevelopmentHubContext> process)
        {
            using (var db = new IndieGameDevelopmentHubContext(optionsBuilder.Options))
            {
                db.Database.EnsureCreated();

                process(db);

                db.SaveChanges();
            }
        }
        public static Form CurrentForm;
        public static HomeScreen HomeScreen;
        [STAThread]
        static void Main()
        {
            optionsBuilder.UseSqlServer(connectionString);  

            ApplicationConfiguration.Initialize();
            CurrentForm = new MainForm();
            Application.Run(CurrentForm);
        }
    }
}