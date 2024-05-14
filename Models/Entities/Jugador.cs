using System.ComponentModel.DataAnnotations;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Tennis.Models
{
    public class Jugador
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Apellido { get; set; }
        public DateTime Nacimiento { get; set; }
        [Required]
        public string Genero { get; set; }
        public int Fuerza { get; set; }
        public int Velocidad { get; set; }
        public int Suerte { get; set; }
        public int Reaccion { get; set; }
        public bool Activo { get; set; }
    }
}
