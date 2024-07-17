using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbPlaIndicadoresMovimento
{
    public int IdMovimento { get; set; }

    public int? IdIndicador { get; set; }

    public short? NrMovimento { get; set; }

    public short? IdTipoMovimento { get; set; }

    public DateTime? DtMovimento { get; set; }

    public int? IdTipoIndicador { get; set; }

    public string? IdNaturezaIndicador { get; set; }

    public string? DsIndicador { get; set; }

    public int? IdPublicoAlvo { get; set; }

    public DateTime? DtBase { get; set; }

    public decimal NrMedidaInicial { get; set; }

    public int? IdVersaoMovimento { get; set; }

    public string? DsNotaExplicativa { get; set; }

    public short? IdUnidadeMedida { get; set; }

    public virtual TbPlaIndicadore? IdIndicadorNavigation { get; set; }

    public virtual TbPlaNaturezasIndicador? IdNaturezaIndicadorNavigation { get; set; }

    public virtual TbPlaPublicosAlvo? IdPublicoAlvoNavigation { get; set; }

    public virtual TbPlaTiposIndicadore? IdTipoIndicadorNavigation { get; set; }

    public virtual TbPlaTiposMovimento? IdTipoMovimentoNavigation { get; set; }

    public virtual TbPlaUnidadesMedidum? IdUnidadeMedidaNavigation { get; set; }

    public virtual TbPlaVerso? IdVersaoMovimentoNavigation { get; set; }

    public virtual ICollection<TbPlaMedidaEsperadaIndicador> TbPlaMedidaEsperadaIndicadors { get; set; } = new List<TbPlaMedidaEsperadaIndicador>();
}
