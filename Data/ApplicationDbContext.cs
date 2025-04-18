using Microsoft.EntityFrameworkCore;
using DiarioMedico.Models;

namespace DiarioMedico.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
    {
        public required DbSet<Cita> Citas { get; set; }

        public required DbSet<Doctor> Doctores { get; set; }

        public required DbSet<Cliente> Clientes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Cita>()
                .HasOne(c => c.Doctor)
                .WithMany(d => d.Citas)
                .HasForeignKey(c => c.DoctorId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}