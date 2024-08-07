﻿using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class VwEmpresasPorAtividadeQuadrimestral
{
    public string Atividade { get; set; } = null!;

    public string? AtividadeDenom { get; set; }

    public int? Ano { get; set; }

    public int? Quadrimestre { get; set; }

    public int? Qtde { get; set; }
}
