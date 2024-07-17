using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbPlaAcoesMetasMovimento
{
    public int IdMovimento { get; set; }

    public int? IdAcao { get; set; }

    public short? NrAno { get; set; }

    public short? NrMovimento { get; set; }

    public DateTime? DtMovimento { get; set; }

    public short? IdTipoMovimento { get; set; }

    public decimal? NrMetaFisica { get; set; }

    public decimal? VlOperacao { get; set; }

    public int? IdVersaoMovimento { get; set; }

    public string? DsNotaExplicativa { get; set; }

    public virtual TbPlaTiposMovimento? IdTipoMovimentoNavigation { get; set; }

    public virtual TbPlaAcoesMeta? TbPlaAcoesMeta { get; set; }

    public virtual ICollection<TbPlaAcoesMetasMovimentosFonte> TbPlaAcoesMetasMovimentosFontes { get; set; } = new List<TbPlaAcoesMetasMovimentosFonte>();
}
