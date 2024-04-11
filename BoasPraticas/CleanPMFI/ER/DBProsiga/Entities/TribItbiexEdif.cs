using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribItbiexEdif
{
    public long ItbiedifId { get; set; }

    public long Itbiid { get; set; }

    public long EdificacaoId { get; set; }

    public decimal? ItbiedifPercTransacao { get; set; }

    public decimal? ItbiedifAreaConstr { get; set; }

    public decimal? ItbiedifVlrVenalIptu { get; set; }

    public decimal? ItbiedifVlrDeclarado { get; set; }

    public string? ItbiedifFinanciado { get; set; }

    public decimal? ItbiedifBaseCalcFin { get; set; }

    public decimal? ItbiedifAliqFinanc { get; set; }

    public decimal? ItbiedifVlrDevido { get; set; }

    public string? ItbiedifTipoConstrucao { get; set; }

    public string? ItbiedifObservacao { get; set; }

    public decimal? ItbiedifBaseCalcImovel { get; set; }

    public decimal? ItbiedifAliquota { get; set; }

    public string? ItbisomaEconomias { get; set; }

    public decimal? ItbiedifPercTransmitir { get; set; }

    public virtual TribEdificaco Edificacao { get; set; } = null!;

    public virtual TribItbiex Itbi { get; set; } = null!;

    public virtual ICollection<TribItbiexCompradore> TribItbiexCompradores { get; set; } = new List<TribItbiexCompradore>();

    public virtual ICollection<TribItbiexVendedore> TribItbiexVendedores { get; set; } = new List<TribItbiexVendedore>();
}
