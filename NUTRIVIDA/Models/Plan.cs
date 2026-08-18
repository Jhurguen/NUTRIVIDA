using System.ComponentModel.DataAnnotations;

namespace NutriVida.Models
{
    public class Plan
    {
        public int Id { get; set; }

        [Required]
        public string NombrePlan { get; set; }

        public string Descripcion { get; set; }

        public DateTime FechaCreacion { get; set; }

        // FK Paciente
        public int PacienteId { get; set; }
        public Paciente Paciente { get; set; }
    }
}
