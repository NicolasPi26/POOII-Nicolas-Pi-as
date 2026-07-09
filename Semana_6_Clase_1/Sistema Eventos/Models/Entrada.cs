using System;
using System.Collections.Generic;

namespace Sistema_Eventos.Models;

public partial class Entrada
{
    public int IdEntrada { get; set; }

    public int? IdEventos { get; set; }

    public int? IdParticipante { get; set; }

    public string? TipoEntrada { get; set; }

    public decimal? Precio { get; set; }

    public DateTime? FechaCompra { get; set; }

    public virtual Evento? IdEventosNavigation { get; set; }

    public virtual Participante? IdParticipanteNavigation { get; set; }

    public virtual ICollection<Pago> Pagos { get; set; } = new List<Pago>();
}
