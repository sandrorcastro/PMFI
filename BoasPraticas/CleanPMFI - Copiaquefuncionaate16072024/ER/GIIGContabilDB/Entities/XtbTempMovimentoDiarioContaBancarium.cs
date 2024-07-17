using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class XtbTempMovimentoDiarioContaBancarium
{
    public string? IdPessoa { get; set; }

    public string? IdOperacaoConta { get; set; }

    public string? NrAnoOperacaoConta { get; set; }

    public string? IdConta { get; set; }

    public string? CdClasse { get; set; }

    public string? CdGrupo { get; set; }

    public string? CdSubGrupo { get; set; }

    public string? CdTitulo { get; set; }

    public string? CdSubTitulo { get; set; }

    public string? CdItem { get; set; }

    public string? CdSubItem { get; set; }

    public string? CdNivel8 { get; set; }

    public string? CdNivel9 { get; set; }

    public string? CdNivel10 { get; set; }

    public string? CdNivel11 { get; set; }

    public string? CdNivel12 { get; set; }

    public string? NrAnoAplicacao { get; set; }

    public string? DtOperacao { get; set; }

    public string? IdTipoOperacaoFinanceira { get; set; }

    public string? VlDebito { get; set; }

    public string? VlCredito { get; set; }

    public string? Nulo { get; set; }
}
