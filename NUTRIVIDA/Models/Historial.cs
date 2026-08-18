using System.ComponentModel.DataAnnotations;

namespace NutriVida.Models
{
    public class Historial
    {
        public int Id { get; set; }

        public int PacienteId { get; set; }
        public Paciente Paciente { get; set; }

        public DateTime FechaConsulta { get; set; }

        public string Observaciones { get; set; }
    }
}
