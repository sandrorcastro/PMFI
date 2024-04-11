using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribFiscAutoLancamentosDivida
{
    public int AutLanDivId { get; set; }

    public int? AutoLanId { get; set; }

    public long? ImoIddivida { get; set; }

    public long? DivEmpId { get; set; }

    public long? ConIddivida { get; set; }

    public short? AutLanDivDiasVencimento { get; set; }

    public byte? AutLanDivDesconto { get; set; }

    public DateTime? AutLanDivDataCiencia { get; set; }
}
