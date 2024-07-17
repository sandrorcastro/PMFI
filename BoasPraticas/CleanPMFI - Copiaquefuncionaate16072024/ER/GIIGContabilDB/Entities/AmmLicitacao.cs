using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class AmmLicitacao
{
    public decimal IdPessoa { get; set; }

    public string NrLicitacao { get; set; } = null!;

    public decimal CdModalidadeLicitacao { get; set; }

    public decimal NrAnoLicitacao { get; set; }

    public decimal? NrPrazoExecucao { get; set; }

    public string? FlRecursoVinculado { get; set; }

    public decimal? CdBanco { get; set; }

    public string? CdAgencia { get; set; }

    public string? CdConta { get; set; }

    public string? DsUnidadeMedida { get; set; }

    public decimal NrBimestreInclusao { get; set; }

    public decimal NrAnoInclusao { get; set; }

    public string? NrLoteItem { get; set; }

    public decimal? CdTipoAvaliacao { get; set; }

    public decimal? CdClassificacaoObjeto { get; set; }

    public decimal? CdRegimeExecucao { get; set; }

    public DateTime? DtConvite { get; set; }

    public DateTime? DtPublicacaoEditalDoe { get; set; }

    public DateTime? DtPublicacaoEdital { get; set; }

    public DateTime? DtPublicacaoEdital2 { get; set; }

    public string? DsVeiculoPublicacao { get; set; }

    public string? DsVeiculoPublicacao2 { get; set; }

    public DateTime? DtAbertura { get; set; }

    public DateTime? DtJulgamento { get; set; }

    public decimal? NrConvidados { get; set; }

    public decimal? NrParticipantes { get; set; }

    public decimal? NrParticipantesHabilitados { get; set; }

    public string StLicitacao { get; set; } = null!;

    public DateTime? DtCancelamento { get; set; }

    public decimal? VlMinimo { get; set; }

    public decimal? VlMaximo { get; set; }

    public string DsObjeto { get; set; } = null!;

    public string DsClausulaPror { get; set; } = null!;

    public string? DsMotivoCancela { get; set; }

    public decimal? IdOrigem { get; set; }

    public byte? CdNaturezaProcedimento { get; set; }

    public string? CdEspecie { get; set; }

    public int? NrRegUltimaAlteracao { get; set; }
}
