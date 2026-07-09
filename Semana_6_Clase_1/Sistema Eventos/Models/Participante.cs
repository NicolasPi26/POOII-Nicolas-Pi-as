using System;
using System.Collections.Generic;

namespace Sistema_Eventos.Models;

public partial class Participante
{
    public int IdParticipante { get; set; }

    public string? Nombre { get; set; }

    public string? Cedula { get; set; }

    public string? Correo { get; set; }

    public string? Telefono { get; set; }

    public virtual ICollection<Entrada> Entrada { get; set; } = new List<Entrada>();
}
