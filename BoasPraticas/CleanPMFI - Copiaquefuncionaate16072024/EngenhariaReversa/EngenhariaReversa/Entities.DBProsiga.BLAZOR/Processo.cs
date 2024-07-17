using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class Processo
    {
        public Processo()
        {
            AlvaraConstrucaoProcessos = new HashSet<AlvaraConstrucaoProcesso>();
            CargasProcessos = new HashSet<CargasProcesso>();
            FissServicoTipoServicos = new HashSet<FissServicoTipoServico>();
            LogProcessos = new HashSet<LogProcesso>();
            OuvidoriaProcessos = new HashSet<OuvidoriaProcesso>();
            TribAdvertencia = new HashSet<TribAdvertencia>();
            TribDividasContribuinteProcessos = new HashSet<TribDividasContribuinteProcesso>();
            Idcarta = new HashSet<TribCartaHabitacao>();
        }

        /// <summary>
        /// Código de Identificação do Processo
        /// </summary>
        public long ProcId { get; set; }
        /// <summary>
        /// Identificação do Tipo do Processo
        /// </summary>
        public int? ProcTipoProcId { get; set; }
        /// <summary>
        /// Código de Identificação  do Contribuinte
        /// </summary>
        public long? ProcIdContribuinte { get; set; }
        /// <summary>
        /// Descrição do objeto do processo
        /// </summary>
        public string? ProcDescricao { get; set; }
        /// <summary>
        /// Data da entrada do processo
        /// </summary>
        public DateTime? ProcDataEntrada { get; set; }
        /// <summary>
        /// Data de encerramento do processo
        /// </summary>
        public DateTime? ProcDataEnc { get; set; }
        /// <summary>
        /// Data prevista para resposta ao contribuinte
        /// </summary>
        public DateTime? ProcDataPrevResp { get; set; }
        /// <summary>
        /// Permite ou não consulta na internet
        /// </summary>
        public string? ProcPublicaWeb { get; set; }
        /// <summary>
        /// Situação do processo
        /// </summary>
        public string? ProcSituacao { get; set; }
        /// <summary>
        /// Identificação da divisão onde o processo está
        /// </summary>
        public int? ProcDivTramitacao { get; set; }
        /// <summary>
        /// Informar se a solicitação foi ou não aprovada
        /// </summary>
        public string? ProcDeferido { get; set; }
        /// <summary>
        /// Informar se a solicitação foi ou não atendida.
        /// </summary>
        public string? ProcAtendido { get; set; }
        public int? ProcAno { get; set; }
        public long? ProcSeqAnual { get; set; }
        public long? ProcServidorId { get; set; }
        public long? ProcArquivId { get; set; }
        public DateTime? ProcDtArquivo { get; set; }
        public DateTime? ProcDtIncineracao { get; set; }

        public virtual ProcArquivamento? ProcArquiv { get; set; }
        public virtual Diviso? ProcDivTramitacaoNavigation { get; set; }
        public virtual Contribuinte? ProcIdContribuinteNavigation { get; set; }
        public virtual Servidore? ProcServidor { get; set; }
        public virtual TipoProcesso? ProcTipoProc { get; set; }
        public virtual ICollection<AlvaraConstrucaoProcesso> AlvaraConstrucaoProcessos { get; set; }
        public virtual ICollection<CargasProcesso> CargasProcessos { get; set; }
        public virtual ICollection<FissServicoTipoServico> FissServicoTipoServicos { get; set; }
        public virtual ICollection<LogProcesso> LogProcessos { get; set; }
        public virtual ICollection<OuvidoriaProcesso> OuvidoriaProcessos { get; set; }
        public virtual ICollection<TribAdvertencia> TribAdvertencia { get; set; }
        public virtual ICollection<TribDividasContribuinteProcesso> TribDividasContribuinteProcessos { get; set; }

        public virtual ICollection<TribCartaHabitacao> Idcarta { get; set; }
    }
}
