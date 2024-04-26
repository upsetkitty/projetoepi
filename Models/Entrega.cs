using System;
using System.Collections.Generic;

namespace projeto_epi.Models;

public partial class Entrega
{
    public int CodEntrega { get; set; }

    public DateOnly DataVal { get; set; }

    public int CodEpi { get; set; }

    public int CodCol { get; set; }

    public DateOnly DataEntrega { get; set; }

    public virtual Colaborador CodColNavigation { get; set; } = null!;

    public virtual Epi CodEpiNavigation { get; set; } = null!;
}
