
using System.ComponentModel.DataAnnotations;
using Tennis.API.Middlewares.CustomDataAnnotations;

namespace Tennis.API.Models.Request
{
    public class AlumnoRequest
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int IdAula { get; set; }
    }
}