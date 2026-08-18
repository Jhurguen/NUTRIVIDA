using System.ComponentModel.DataAnnotations;

namespace NutriVida.Models
{
    public class Paciente
    {
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; }

        public int Edad { get; set; }

        public string Sexo { get; set; }

        public string Email { get; set; }

        public string Telefono { get; set; }

        // Relación con Planes
        public List<Plan> Planes { get; set; }
    }
}
