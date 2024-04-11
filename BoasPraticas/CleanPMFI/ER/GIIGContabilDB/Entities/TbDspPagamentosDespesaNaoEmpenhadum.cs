using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbDspPagamentosDespesaNaoEmpenhadum
{
    public int IdPagtoNaoEmpenhada { get; set; }

    public short? IdEmpresa { get; set; }

    public short? NrAno { get; set; }

    public short? NrMes { get; set; }

    public int? NrSequencia { get; set; }

    public int? IdPagamento { get; set; }

    public int? IdEmpenho { get; set; }
}
