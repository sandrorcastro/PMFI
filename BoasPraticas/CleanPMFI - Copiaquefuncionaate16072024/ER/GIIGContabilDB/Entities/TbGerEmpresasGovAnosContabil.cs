using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbGerEmpresasGovAnosContabil
{
    public short Idempresa { get; set; }

    public short NrAnoContabil { get; set; }

    public DateTime? DtAberturaOrcamento { get; set; }

    public int? NrLeiLoa { get; set; }

    public short? NrAnoLeiLoa { get; set; }

    public DateTime? DtLeiLoa { get; set; }

    public DateTime? DtPublicacaoLeiLoa { get; set; }

    public int? NrLeiPpa { get; set; }

    public short? NrAnoPpa { get; set; }

    public DateTime? DtLeiPpa { get; set; }

    public DateTime? DtPublicacaoLeiPpa { get; set; }

    public int? NrLeiLdo { get; set; }

    public short? NrAnoLdo { get; set; }

    public DateTime? DtLeiLdo { get; set; }

    public DateTime? DtPublicacaoLeiLdo { get; set; }

    public short? NrBimestreFechado { get; set; }

    public DateTime? DtAberturaAnoContabil { get; set; }

    public int? IdLeiAtoLoa { get; set; }

    public short? NrMesReceitaFechada { get; set; }

    public short? NrMesDespesaFechada { get; set; }

    public short? NrMesContabilFechado { get; set; }

    public string? NrDecretoQdd { get; set; }

    public DateTime? DtPublicacaoQdd { get; set; }

    public string? DsLogin { get; set; }

    public string? DsAberturaEncerramento { get; set; }

    public string? DsMovimentoReceita { get; set; }

    public string? DsMovimentoDespesa { get; set; }

    public string? DsMovimentoContabil { get; set; }

    public virtual TbGerEmpresasGoverno IdempresaNavigation { get; set; } = null!;
}
