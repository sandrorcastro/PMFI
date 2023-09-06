using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbLicParticipante
    {
        public TbLicParticipante()
        {
            TbLicParticipanteTecnicas = new HashSet<TbLicParticipanteTecnica>();
            TbLicParticipantesLotesCotacaos = new HashSet<TbLicParticipantesLotesCotacao>();
            TbLicParticipantesSituacaos = new HashSet<TbLicParticipantesSituacao>();
        }

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
        public virtual ICollection<TbLicParticipanteTecnica> TbLicParticipanteTecnicas { get; set; }
        public virtual ICollection<TbLicParticipantesLotesCotacao> TbLicParticipantesLotesCotacaos { get; set; }
        public virtual ICollection<TbLicParticipantesSituacao> TbLicParticipantesSituacaos { get; set; }
    }
}
