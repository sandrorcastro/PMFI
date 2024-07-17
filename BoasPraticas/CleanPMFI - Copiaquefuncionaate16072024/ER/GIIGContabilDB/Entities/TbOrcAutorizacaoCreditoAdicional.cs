using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbOrcAutorizacaoCreditoAdicional
{
    public int IdAutorizacao { get; set; }

    public int? IdArtigo { get; set; }

    public short? IdTipoCreditoAdicional { get; set; }

    public string? TpValor { get; set; }

    public short? TpBaseCalculo { get; set; }

    public decimal? VlAutorizado { get; set; }

    public DateTime? DtInclusao { get; set; }

    public string? DsLogin { get; set; }

    public virtual TbOrcArtigosCreditoAdicional? IdArtigoNavigation { get; set; }

    public virtual TbOrcTipoCreditoAdicional? IdTipoCreditoAdicionalNavigation { get; set; }
}
