using System;
using System.Collections.Generic;

namespace Sistema_libreria.Models;

public partial class Venta
{
    public int IdVenta { get; set; }

    public int? IdLibro { get; set; }

    public int? Cantidad { get; set; }

    public DateOnly? FechaVenta { get; set; }

    public decimal? Total { get; set; }

    public virtual Libro? IdLibroNavigation { get; set; }
}
