using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Mysql_ORM.Datos.Entidades
{
    public class Clientes
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public string correo {  get; set; }

        [NotMapped]
        public string NombreCompleto => $"{nombre} {apellido}".Trim();
    
    }
}
