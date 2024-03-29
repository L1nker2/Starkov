using Microsoft.EntityFrameworkCore;
using System.Resources;

namespace Starkov.Models
{
    public class DataBaseContext: DbContext
    {
        public static string sqlstr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|Starkov.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True";
        public DbSet<Contract> Contracts { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<House> Houses { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(sqlstr);

        }
    }
}
