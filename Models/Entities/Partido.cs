using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tennis.Models
{
    public class Partido
    {
        [Key]
        public int Id { get; set; }
        public int IdTorneo { get; set; }
        [ForeignKey(nameof(IdTorneo))]
        public virtual Torneo Torneo { get; set; }
        public int IdJugador1 { get; set; }
        [ForeignKey(nameof(IdJugador1))]
        public Jugador Jugador1 { get; set; }
        public int IdJugador2 { get; set; }
        [ForeignKey(nameof(IdJugador2))]
        public Jugador Jugador2 { get; set; }
        public int Dificultad { get; set; }
        public string? Resultado { get; set; }
    }
}
