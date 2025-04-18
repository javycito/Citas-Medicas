using DiarioMedico.Data;
using DiarioMedico.Models;
using Microsoft.EntityFrameworkCore;

namespace DiarioMedico.Services
{
    public class CitaService(ApplicationDbContext context)
    {
        public async Task<List<Cita>> GetCitasAsync()
        {
            return await context.Citas.Include(c => c.Doctor).ToListAsync();
        }

        public async Task<Cita?> GetCitaByIdAsync(int id)
        {
            return await context.Citas.Include(c => c.Doctor).FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task CreateCitaAsync(Cita cita)
        {
            context.Citas.Add(cita);
            await context.SaveChangesAsync();
        }

        public async Task UpdateCitaAsync(Cita cita)
        {
            context.Citas.Update(cita);
            await context.SaveChangesAsync();
        }

        public async Task DeleteCitaAsync(int id)
        {
            var cita = await GetCitaByIdAsync(id);
            if (cita != null)
            {
                context.Citas.Remove(cita);
                await context.SaveChangesAsync();
            }
        }

        public async Task<List<Doctor>> ObtenerDoctores()
        {
            return await context.Doctores.ToListAsync();
        }
    }
}