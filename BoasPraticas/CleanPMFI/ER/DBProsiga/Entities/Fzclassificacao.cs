using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class Fzclassificacao
{
    public int FzclassifVeiId { get; set; }

    public string? FzclassifVeiNome { get; set; }

    public virtual ICollection<Fzveiculo> Fzveiculos { get; set; } = new List<Fzveiculo>();
}
