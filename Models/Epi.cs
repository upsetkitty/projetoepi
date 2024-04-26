using System;
using System.Collections.Generic;

namespace projeto_epi.Models;

public partial class Epi
{
    public int CodEpi { get; set; }

    public string NomeEpi { get; set; } = null!;

    public string Descricao { get; set; } = null!;

    public virtual ICollection<Entrega> Entregas { get; } = new List<Entrega>();
}
