using System;
using System.Collections.Generic;

namespace Sistema_Eventos.Models;

public partial class Pago
{
    public int IdPago { get; set; }

    public int? IdEntrada { get; set; }

    public string? MetodoPago { get; set; }

    public decimal? Monto { get; set; }

    public DateTime? FechaPago { get; set; }

    public virtual Entrada? IdEntradaNavigation { get; set; }
}
