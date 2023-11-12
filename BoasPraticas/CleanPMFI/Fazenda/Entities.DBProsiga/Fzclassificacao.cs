using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class Fzclassificacao
{
    public int FzclassifVeiId { get; set; }

    public string? FzclassifVeiNome { get; set; }

    public virtual ICollection<Fzveiculo> Fzveiculos { get; set; } = new List<Fzveiculo>();
}
