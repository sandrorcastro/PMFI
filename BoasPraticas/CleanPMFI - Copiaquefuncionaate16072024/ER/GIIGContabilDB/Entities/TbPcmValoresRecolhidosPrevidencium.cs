using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbPcmValoresRecolhidosPrevidencium
{
    public int IdRegime { get; set; }

    public string? TpRegime { get; set; }

    public short? NrMesCompetencia { get; set; }

    public short? NrAnoCompetencia { get; set; }

    public DateTime? DtRecolhimento { get; set; }

    public DateTime? DtVencimento { get; set; }

    public decimal? VlPrincipalEmpregados { get; set; }

    public decimal? VlPrincipalEmpregador { get; set; }

    public decimal? VlJurosMultas { get; set; }

    public decimal? VlAtualizacaoMonetaria { get; set; }
}
