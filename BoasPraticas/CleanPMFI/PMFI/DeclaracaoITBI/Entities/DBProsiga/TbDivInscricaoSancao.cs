using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class TbDivInscricaoSancao
{
    public int IdInscricao { get; set; }

    public long? ConId { get; set; }

    public long? ConIddivida { get; set; }

    public int? IdCredito { get; set; }

    public string? TpCredito { get; set; }

    public int? NrOperacao { get; set; }

    public short? NrAnoOperacao { get; set; }

    public int? NrProcesso { get; set; }

    public short? NrAnoProcesso { get; set; }

    public short? IdTipoUnidadeTce { get; set; }

    public string? TpAtoSancao { get; set; }

    public int? NrAto { get; set; }

    public short? NrAnoAto { get; set; }

    public int? NrCertidao { get; set; }

    public short? NrAnoCertidao { get; set; }

    public decimal? VlOriginalSancao { get; set; }

    public decimal? VlInscricao { get; set; }

    public int? ConIdsolidario { get; set; }

    public virtual TbDivLancamentoCredito? IdCreditoNavigation { get; set; }

    public virtual TbDivTipoUnidadeTce? IdTipoUnidadeTceNavigation { get; set; }
}
