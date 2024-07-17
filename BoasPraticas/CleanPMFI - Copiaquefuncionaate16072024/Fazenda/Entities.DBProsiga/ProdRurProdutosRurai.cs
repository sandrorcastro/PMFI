using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class ProdRurProdutosRurai
{
    public int IdprodRural { get; set; }

    public string? Nome { get; set; }

    public int? IdativRural { get; set; }

    public virtual ProdRurAtividadeRural? IdativRuralNavigation { get; set; }

    public virtual ICollection<ProdRurNotaFiscalIten> ProdRurNotaFiscalItens { get; set; } = new List<ProdRurNotaFiscalIten>();

    public virtual ICollection<ProdRurProducao> ProdRurProducaos { get; set; } = new List<ProdRurProducao>();
}
