using System.ComponentModel.DataAnnotations;

namespace DiarioMedico.Models
{
    public class Cliente
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio.")]
        public string Nombre { get; set; } = string.Empty;

        [Required(ErrorMessage = "El email es obligatorio.")]
        public required string Email { get; set; } = string.Empty;

        public string? Telefono { get; set; }

        public List<Cita> Citas { get; set; } = [];
    }
}