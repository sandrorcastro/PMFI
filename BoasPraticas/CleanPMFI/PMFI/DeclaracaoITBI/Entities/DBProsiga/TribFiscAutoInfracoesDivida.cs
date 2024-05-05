using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class TribFiscAutoInfracoesDivida
{
    public int AutDivId { get; set; }

    public int? AutoId { get; set; }

    public long? ImoIddivida { get; set; }

    public long? DivEmpId { get; set; }

    public long? ConIddivida { get; set; }

    public short? AutDivDiasVencimento { get; set; }

    public byte? AutDivDesconto { get; set; }

    public DateTime? AutDivDataCiencia { get; set; }
}
