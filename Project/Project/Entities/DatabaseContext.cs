using Microsoft.EntityFrameworkCore;

namespace Project.Entities

{
    public class DatabaseContext : DbContext   /*entity frameworktan gelen dbcontextten miras alıyoruz*/
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<User> UserData { get; set; }    /*Users tablosuna erismek icin bir database seti user tipinde su user classını vererek söylüyoruz*/
    }


}
