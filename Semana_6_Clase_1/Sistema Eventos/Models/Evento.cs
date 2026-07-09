using System;
using System.Collections.Generic;

namespace Sistema_Eventos.Models;

public partial class Evento
{
    public int IdEventos { get; set; }

    public string NombreEvento { get; set; } = null!;

    public string? Lugar { get; set; }

    public DateOnly? Fecha { get; set; }

    public TimeOnly? Hora { get; set; }

    public int? Capacidad { get; set; }

    public virtual ICollection<Entrada> Entrada { get; set; } = new List<Entrada>();
}
