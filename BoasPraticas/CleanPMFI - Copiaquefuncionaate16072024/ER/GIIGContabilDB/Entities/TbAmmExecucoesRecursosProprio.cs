using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbAmmExecucoesRecursosProprio
{
    public int IdExecucao { get; set; }

    public short? IdEmpresa { get; set; }

    public int? CdConvenioAuxilio { get; set; }

    public string? FlOperacao { get; set; }

    public short? NrAnoEmpenho { get; set; }

    public int? NrEmpenho { get; set; }

    public DateTime? DtPagamento { get; set; }

    public int? NrPagamento { get; set; }

    public string? CdFonte { get; set; }

    public decimal? VlExecucao { get; set; }

    public short? NrAnoPagamento { get; set; }
}
