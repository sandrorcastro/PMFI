using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGProtocoloDB
{
    public partial class TabProcesso
    {
        public TabProcesso()
        {
            TabArquivos = new HashSet<TabArquivo>();
            TabAtributoProcessos = new HashSet<TabAtributoProcesso>();
            TabMovimentos = new HashSet<TabMovimento>();
            TabProcessoInteressados = new HashSet<TabProcessoInteressado>();
            TabProcessoNotificacos = new HashSet<TabProcessoNotificaco>();
        }

        public long ProcId { get; set; }
        public short? ProcAno { get; set; }
        public int? ProcSequencia { get; set; }
        public DateTime? ProcData { get; set; }
        public short? AssuId { get; set; }
        public string? ProcComplemento { get; set; }
        public int? PessId { get; set; }
        public string? ProcPublicoWeb { get; set; }
        public byte? PrioId { get; set; }
        /// <summary>
        /// Contem o status do processo
        /// TR -&gt; Tramite
        /// TI -&gt; Tramite Indeferido
        /// TD -&gt; Tramite Deferido
        /// AR -&gt; Arquivado
        /// AI -&gt; Arquivado Indeferido
        /// AD -&gt; Arquivado Deferido
        /// JP -&gt; Juntado por apensação
        /// JX -&gt; Juntado por anexação
        /// 
        /// </summary>
        public string? ProcStatus { get; set; }
        public long? BarrId { get; set; }
        public long? IdSolicitacao { get; set; }
        public int? NrPaginas { get; set; }
        public byte? ProcTempoEstimado { get; set; }
        public string? Dslinkpublico { get; set; }

        public virtual TabAssunto? Assu { get; set; }
        public virtual TabPessoa? Pess { get; set; }
        public virtual TabPrioridade? Prio { get; set; }
        public virtual ICollection<TabArquivo> TabArquivos { get; set; }
        public virtual ICollection<TabAtributoProcesso> TabAtributoProcessos { get; set; }
        public virtual ICollection<TabMovimento> TabMovimentos { get; set; }
        public virtual ICollection<TabProcessoInteressado> TabProcessoInteressados { get; set; }
        public virtual ICollection<TabProcessoNotificaco> TabProcessoNotificacos { get; set; }
    }
}
