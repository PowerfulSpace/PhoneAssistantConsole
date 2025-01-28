using Microsoft.EntityFrameworkCore;
using PhoneAssistantConsole.Entities;

namespace PhoneAssistantConsole.Context
{
    public class PhoneBookContext : DbContext
    {
        public DbSet<Contact> Contacts { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Server=DESKTOP-F9SMEKT;Database=PhoneAssistantConsole_Db;Trusted_Connection=True;TrustServerCertificate=True");
            optionsBuilder.UseSqlServer("Server=DESKTOP-F9SMEKT;Database=PhoneAssistantConsole_Db_Test;Trusted_Connection=True;TrustServerCertificate=True");
        }
    }
}

//Внести изенения для новой ветки
//Изменить базу данных, и его схему. Т.к отсутствует Email