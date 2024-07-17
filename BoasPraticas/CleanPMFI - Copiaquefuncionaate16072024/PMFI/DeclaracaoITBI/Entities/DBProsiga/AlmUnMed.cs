using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class AlmUnMed
{
    public int UnMedId { get; set; }

    public string? UnMedNome { get; set; }

    public string? UnMedSigla { get; set; }

    public virtual ICollection<AlmIten> AlmItens { get; set; } = new List<AlmIten>();

    public virtual ICollection<MoveisIten> MoveisItens { get; set; } = new List<MoveisIten>();

    public virtual ICollection<ProdRurNotaFiscalIten> ProdRurNotaFiscalItens { get; set; } = new List<ProdRurNotaFiscalIten>();

    public virtual ICollection<ProdRurProducao> ProdRurProducaos { get; set; } = new List<ProdRurProducao>();

    public virtual ICollection<TbObrIntervencao> TbObrIntervencaos { get; set; } = new List<TbObrIntervencao>();

    public virtual ICollection<TribTipoPublicidade> TribTipoPublicidades { get; set; } = new List<TribTipoPublicidade>();
}
