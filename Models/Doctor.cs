namespace DiarioMedico.Models
{
    public class Doctor
    {
        public int Id { get; set; }
        public required string Nombre { get; set; }
        public required string Especialidad { get; set; }
        public required string Email {  get; set; }
        public List<Cita> Citas { get; set; } = []; 
    }
}
