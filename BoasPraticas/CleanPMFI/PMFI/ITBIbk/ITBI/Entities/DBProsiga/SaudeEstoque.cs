﻿using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class SaudeEstoque
{
    public int IdEstoque { get; set; }

    public string? NomeEstoque { get; set; }

    public string? EmailResponsavel { get; set; }

    public int? IdSetor { get; set; }

    public int? IdUnidadeSaudeSetor { get; set; }

    public virtual ICollection<SaudeFarmaSaldoInicial> SaudeFarmaSaldoInicials { get; set; } = new List<SaudeFarmaSaldoInicial>();

    public virtual ICollection<Usuario> Usus { get; set; } = new List<Usuario>();
}
