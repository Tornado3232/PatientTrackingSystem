using Microsoft.EntityFrameworkCore;
using PatientTrackingSystem.Server.Models;

namespace PatientTrackingSystem.Server.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Patient> Patients { get; set; }
    }
}
