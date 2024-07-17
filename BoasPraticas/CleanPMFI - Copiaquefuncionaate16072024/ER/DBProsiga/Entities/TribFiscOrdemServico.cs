using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribFiscOrdemServico
{
    public int FiscOsid { get; set; }

    public DateTime? FiscOsdata { get; set; }

    public long? ConId { get; set; }

    public string? FiscOsassunto { get; set; }

    public string? FiscOsprovidencias { get; set; }

    public int? TipoFiscId { get; set; }

    public string? Bairro { get; set; }

    public string? Endereco { get; set; }

    public int? FiscOsnumero { get; set; }

    public int? FiscOsano { get; set; }

    public int? IdAssunto { get; set; }

    public string? FiscProcesso { get; set; }

    public string? FiscReclamacao { get; set; }

    public long? EmprCmc { get; set; }

    public long? EdificacaoId { get; set; }

    public string? FiscUsuarioInclusao { get; set; }

    public string? FiscStatus { get; set; }

    public string? FiscUsuarioAutorizacao { get; set; }

    public string? FiscObservacao { get; set; }

    public int? FiscNrDias { get; set; }

    public int? FiscNrProrrogacao { get; set; }

    public DateTime? FiscDtAutorizado { get; set; }

    public DateTime? FiscDtFinalizado { get; set; }

    public int? IdservidorExpeditor { get; set; }

    public int? NrProtocolo { get; set; }

    public virtual TribFiscTipoFiscal? TipoFisc { get; set; }

    public virtual ICollection<TribFiscOrdemServicoOcorrencia> TribFiscOrdemServicoOcorrencia { get; set; } = new List<TribFiscOrdemServicoOcorrencia>();

    public virtual ICollection<TribFiscOsreclamaco> TribFiscOsreclamacos { get; set; } = new List<TribFiscOsreclamaco>();

    public virtual ICollection<TribFiscVistoria> TribFiscVistoria { get; set; } = new List<TribFiscVistoria>();
}
