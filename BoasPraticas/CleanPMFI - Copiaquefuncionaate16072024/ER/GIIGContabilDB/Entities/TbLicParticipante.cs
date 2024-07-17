using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbLicParticipante
{
    public int IdParticipante { get; set; }

    public int? IdLicitacao { get; set; }

    public DateTime? DtConvite { get; set; }

    public int? IdPessoa { get; set; }

    public int? IdPessoaRepresentante { get; set; }

    public int? IdCrcf { get; set; }

    public DateTime? DtCredenciamento { get; set; }

    public string? FlConvidado { get; set; }

    public string? FlHabilitado { get; set; }

    public string? DsMotivoNaoHabilitacao { get; set; }

    public string? DsLogin { get; set; }

    public DateTime? DtInclusao { get; set; }

    public int? NrIdade { get; set; }

    public int? IdParticipanteOrigem { get; set; }

    public virtual TbLicLicitaco? IdLicitacaoNavigation { get; set; }

    public virtual TbGerPessoa? IdPessoaNavigation { get; set; }

    public virtual ICollection<TbLicParticipanteTecnica> TbLicParticipanteTecnicas { get; set; } = new List<TbLicParticipanteTecnica>();

    public virtual ICollection<TbLicParticipantesLotesCotacao> TbLicParticipantesLotesCotacaos { get; set; } = new List<TbLicParticipantesLotesCotacao>();

    public virtual ICollection<TbLicParticipantesSituacao> TbLicParticipantesSituacaos { get; set; } = new List<TbLicParticipantesSituacao>();
}
