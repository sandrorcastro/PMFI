using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbDspAquisicaoBensIten
{
    public int IdAquisicao { get; set; }

    public int IdItem { get; set; }

    public int? NrQtde { get; set; }

    public decimal? VlUnitario { get; set; }

    public decimal? VlTotal { get; set; }

    public int IdEmpenho { get; set; }

    public string? DsMarca { get; set; }

    public int IdNatDespesa { get; set; }

    public int? IdItemOrigem { get; set; }

    public string? IdItensOrigem { get; set; }
}
