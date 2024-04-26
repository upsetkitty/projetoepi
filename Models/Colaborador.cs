﻿using System;
using System.Collections.Generic;

namespace projeto_epi.Models;

public partial class Colaborador
{
    public int CodCol { get; set; }

    public string NomeCol { get; set; } = null!;

    public decimal Cpf { get; set; }

    public int Ctps { get; set; }

    public DateOnly DataAdmissao { get; set; }

    public int NumTel { get; set; }

    public string Email { get; set; } = null!;

    public virtual ICollection<Entrega> Entregas { get; } = new List<Entrega>();
}
