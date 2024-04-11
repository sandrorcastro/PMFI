using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbRecMovimentoReceitasAporte
{
    public int IdAporte { get; set; }

    public int IdMovReceita { get; set; }

    public int? IdFonte { get; set; }

    public decimal? VlDolares { get; set; }

    public decimal? VlCambio { get; set; }

    public virtual TbRecMovimentoReceita IdMovReceitaNavigation { get; set; } = null!;

    public virtual ICollection<TbDspPagamentosAporte> TbDspPagamentosAportes { get; set; } = new List<TbDspPagamentosAporte>();
}
