using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbDspLiquidacoesDoctosIten
{
    public int IdLiquidacaoDoctoItem { get; set; }

    public int IdLiquidacaoDocto { get; set; }

    public int IdItem { get; set; }

    public int? IdNatDespesa { get; set; }

    public decimal? NrQtde { get; set; }

    public decimal? VlTotal { get; set; }

    public int? NrLote { get; set; }

    public decimal? VlDesconto { get; set; }

    public virtual TbDspLiquidacoesDocumento IdLiquidacaoDoctoNavigation { get; set; } = null!;
}
