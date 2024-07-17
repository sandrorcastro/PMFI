using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbDspNumeracoesBaixasRap
{
    public int IdNumeracaoBaixaRap { get; set; }

    public short? IdEmpresa { get; set; }

    public short? NrAno { get; set; }

    public int? NrSequenciaBaixa { get; set; }

    public int? IdPagamento { get; set; }

    public int? IdEstorno { get; set; }

    public DateTime? DtObjeto { get; set; }
}
