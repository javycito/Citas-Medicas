using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DiarioMedico.Models
{
    public class Cita
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "La fecha es obligatoria.")]
        public DateTime Fecha { get; set; }

        [Required(ErrorMessage = "La hora es obligatoria.")]
        public TimeOnly? Hora { get; set; }

        [Required(ErrorMessage = "El nombre del cliente es obligatorio.")]
        public required string NombredeCliente { get; set; }
        public Doctor? Doctor { get; set; }
        public required Cliente Cliente { get; set; }

        [ForeignKey("Doctor")]
        [Required(ErrorMessage = "Debe seleccionar un doctor.")]
        public int DoctorId { get; set; }
    }

}