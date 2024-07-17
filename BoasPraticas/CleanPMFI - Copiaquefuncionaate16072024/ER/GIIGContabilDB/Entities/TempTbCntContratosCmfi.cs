using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TempTbCntContratosCmfi
{
    public int IdContrato { get; set; }

    public short? IdEmpresa { get; set; }

    public short? NrAno { get; set; }

    public short? IdTipoContrato { get; set; }

    public short? CdTipoAtoContratual { get; set; }

    public int? NrContrato { get; set; }

    public DateTime? DtContrato { get; set; }

    public string? CdOrgao { get; set; }

    public string? NmOrgao { get; set; }

    public string? CdUnidade { get; set; }

    public int? IdPessoa { get; set; }

    public int? IdPessoaRepresentante { get; set; }

    public int? IdLicitacao { get; set; }

    public string? DsObjeto { get; set; }

    public DateTime? DtInicioPrazo { get; set; }

    public DateTime? DtTerminoPrazo { get; set; }

    public short? IdRegimeExecucao { get; set; }

    public string? FlPrevisaoSubContratacao { get; set; }

    public string? FlFornecimentoImediato { get; set; }

    public decimal? VlContrato { get; set; }

    public string? DsFormaPagamento { get; set; }

    public string? DsMultaRescisoria { get; set; }

    public string? DsMultaInadimplemento { get; set; }

    public short IdTipoGarantia { get; set; }

    public DateTime? DtAssinatura { get; set; }

    public decimal? VlRecursoOperCredito { get; set; }

    public short? IdVeiculoPublicacao { get; set; }

    public DateTime? DtPublicacao { get; set; }

    public int? IdTcecontrato { get; set; }

    public string? DsLogin { get; set; }

    public DateTime? DtInclusao { get; set; }

    public string? DsContratoGerado { get; set; }

    public string? NrProtocolo { get; set; }

    public short? IdTipoOrigemContrato { get; set; }

    public string? FlCessaoContratual { get; set; }

    public short? IdCondicaoPgto { get; set; }

    public short? IdTipoMultaContrato { get; set; }

    public string? DsGarantiaContrato { get; set; }

    public int? IdPessoaOrigem { get; set; }

    public string? TpClassificacaoContabil { get; set; }

    public string? CdTcm { get; set; }

    public string? DsLoginAlteracao { get; set; }

    public DateTime? DtAlteracao { get; set; }

    public int? IdContratoOrigem { get; set; }
}
