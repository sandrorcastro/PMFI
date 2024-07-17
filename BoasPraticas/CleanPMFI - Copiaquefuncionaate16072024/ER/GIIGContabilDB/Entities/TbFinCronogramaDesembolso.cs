using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbFinCronogramaDesembolso
{
    public int IdCronograma { get; set; }

    public short? IdEmpresa { get; set; }

    public int? IdLeiAto { get; set; }

    public short IdTipoOperacao { get; set; }

    public short? NrMes { get; set; }

    public short? NrAno { get; set; }

    public int? IdFonte { get; set; }

    public decimal? VlOperacao { get; set; }

    public string? DsLogin { get; set; }

    public DateTime? DtInclusao { get; set; }

    public virtual TbFinTipoOperacaoProgramacaoFinanceira IdTipoOperacaoNavigation { get; set; } = null!;
}
