using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class Rapam
{
    public double? IdPessoa { get; set; }

    public int? IdEmpresa { get; set; }

    public int? NrEmpenho { get; set; }

    public int? NrAnoEmpenho { get; set; }

    public int? NrAnoInclusao { get; set; }

    public int? NrBimestreInclusao { get; set; }

    public string? CdFonte { get; set; }

    public string? CdModalidadeLicitacao { get; set; }

    public string? NrLicitacao { get; set; }

    public string? NrAnoLicitacao { get; set; }

    public string? CdBanco { get; set; }

    public string? CdAgencia { get; set; }

    public string? CdConta { get; set; }

    public DateTime? DtEmpenho { get; set; }

    public decimal? VlProcessado { get; set; }

    public decimal? VlNaoProcessado { get; set; }

    public string? CdNaturezaDespesa { get; set; }

    public string? CdAreaAtuacao { get; set; }

    public string? CdFuncionalProgramatica { get; set; }

    public string? FlRecursoVinculado { get; set; }

    public string? CdConvenioAuxilio { get; set; }

    public string? TpDocCredor { get; set; }

    public string? NrDocCredor { get; set; }

    public string? CdContabilCredor { get; set; }

    public string? NmCredor { get; set; }

    public string? IdContrato { get; set; }

    public string? FlProcessado { get; set; }

    public string? FlServicoDivida { get; set; }

    public string? DsHistorico { get; set; }

    public string? CdProjetoAtividade { get; set; }

    public decimal? VlRestosApagar { get; set; }

    public string? FlIndContrapartida { get; set; }

    public string? VlPagoLiquido { get; set; }

    public string? VlCanceladoLiquido { get; set; }

    public string? CdControle { get; set; }

    public string? CdBemObrigacao { get; set; }

    public int? IdEmpenho { get; set; }
}
