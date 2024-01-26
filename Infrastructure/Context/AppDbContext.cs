using Microsoft.EntityFrameworkCore;
using MVC_Telefon_Kayit.Models.Entities.Concrete;

namespace MVC_Telefon_Kayit.Infrastructure.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {
                
        }
        public DbSet<Phone> Phones { get; set; }
    }
}
