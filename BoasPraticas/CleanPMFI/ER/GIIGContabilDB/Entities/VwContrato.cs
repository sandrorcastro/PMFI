using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class VwContrato
{
    public string? NrCnpj { get; set; }

    public short? NrAno { get; set; }

    public int? NrContrato { get; set; }

    public DateTime? DtContrato { get; set; }

    public decimal? VlContrato { get; set; }

    public DateTime? DtTerminoPrazo { get; set; }

    public string? DsObjeto { get; set; }

    public string? NrCnpjcpf { get; set; }

    public string? IdContrato { get; set; }

    public short? IdTipoContrato { get; set; }

    public short? IdRegimeExecucao { get; set; }

    public string? DsSigla { get; set; }

    public string? CdOrgao { get; set; }

    public string? NmOrgao { get; set; }

    public string? Representante { get; set; }

    public short? IdModalidade { get; set; }

    public string? NumLicitacao { get; set; }

    public string? FlPrevisaoSubContratacao { get; set; }

    public string? FlFornecimentoImediato { get; set; }

    public string? DsFormaPagamento { get; set; }

    public int RecProprios { get; set; }

    public int RecEstadual { get; set; }

    public int RecFederal { get; set; }

    public string? DsMultaRescisoria { get; set; }

    public string? DsMultaInadimplemento { get; set; }

    public string RespEncargos { get; set; } = null!;

    public DateTime? DtAssinatura { get; set; }

    public string UtilizaRecExtra { get; set; } = null!;

    public decimal? VlRecursoOperCredito { get; set; }

    public int IdAm { get; set; }

    public string PrazoExecucao { get; set; } = null!;
}
