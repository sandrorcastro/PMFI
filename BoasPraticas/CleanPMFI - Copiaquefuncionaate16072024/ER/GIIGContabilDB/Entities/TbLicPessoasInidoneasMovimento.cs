using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbLicPessoasInidoneasMovimento
{
    public int IdInidoneosMovimento { get; set; }

    public int? IdInidoneos { get; set; }

    public string? DsTipoLancamento { get; set; }

    public string? NrProcessoAdm { get; set; }

    public DateTime? DtPublicacao { get; set; }

    public string? TpImpedimento { get; set; }

    public DateTime? DtInicio { get; set; }

    public DateTime? DtFim { get; set; }

    public string? DsHistorico { get; set; }

    public DateTime? DtInclusao { get; set; }

    public string? DsLogin { get; set; }
}
