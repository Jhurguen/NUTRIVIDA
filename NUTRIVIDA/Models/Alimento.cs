using System.ComponentModel.DataAnnotations;

namespace NutriVida.Models
{
    public class Alimento
    {
        public int Id { get; set; }

        [Required]
        public string NombreAlimento { get; set; }

        public string Tipo { get; set; }

        public int Calorias { get; set; }
    }
}
