using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class Tempbktbdidiarioarrecadacao
{
    public int IdArrecadacao { get; set; }

    public int? IdCredito { get; set; }

    public string? TpCredito { get; set; }

    public int? NrArrecadacao { get; set; }

    public short? NrAnoArrecadacao { get; set; }

    public int? TipoTribId { get; set; }

    public string? CdReceita { get; set; }

    public short? NrAnoPlanoContas { get; set; }

    public short? IdTipoOrigemReceita { get; set; }

    public string? TpDocContribuinte { get; set; }

    public string? NrDocContribuinte { get; set; }

    public string? NmContribuinte { get; set; }

    public short? IdTipoArrecadacao { get; set; }

    public DateTime? DtArrecadacao { get; set; }

    public decimal? VlArrecadacao { get; set; }

    public string? DsHistorico { get; set; }

    public string? DsLoginInclusao { get; set; }

    public int? IdCreditoDivida { get; set; }

    public int? IdConvenio { get; set; }

    public int? IdDeducao { get; set; }
}
