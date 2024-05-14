using System.ComponentModel.DataAnnotations;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Tennis.Models
{
    public class Torneo
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        public int CreatedByUserId { get; set; }
        public string Genero { get; set; }
        public List<Jugador> Jugadores { get; set; }
        public string Dificultad { get; set; }
        public string Resultado { get; set; }
    }
}
