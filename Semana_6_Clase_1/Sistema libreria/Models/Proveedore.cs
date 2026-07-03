using System;
using System.Collections.Generic;

namespace Sistema_libreria.Models;

public partial class Proveedore
{
    public int IdProveedor { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Telefono { get; set; }

    public string? Correo { get; set; }

    public virtual ICollection<Libro> Libros { get; set; } = new List<Libro>();
}
