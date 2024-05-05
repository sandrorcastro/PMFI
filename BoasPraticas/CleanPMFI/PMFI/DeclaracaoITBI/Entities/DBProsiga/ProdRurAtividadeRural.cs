using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class ProdRurAtividadeRural
{
    public int IdativRural { get; set; }

    public string? Nome { get; set; }

    public virtual ICollection<ProdRurProdutosRurai> ProdRurProdutosRurais { get; set; } = new List<ProdRurProdutosRurai>();
}
