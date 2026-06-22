using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mecanicas_Tarean6_Nicolas_Piñas.Data.Entidades
{
    public class Clientes
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string modelo { get; set; }
        public string marca { get; set; }
        public string placa { get; set; }

        [NotMapped]
        public string NombreCompleto {
            get {
                return nombre + " " + apellido;
 
            } 
        }
    }
}
