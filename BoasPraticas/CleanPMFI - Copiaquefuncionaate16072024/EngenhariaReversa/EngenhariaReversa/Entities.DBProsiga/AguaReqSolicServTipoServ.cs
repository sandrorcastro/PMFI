using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class AguaReqSolicServTipoServ
    {
        public AguaReqSolicServTipoServ()
        {
            AguaReqSolicServParcs = new HashSet<AguaReqSolicServParc>();
        }

        /// <summary>
        /// Identificação do tipo de servico da agua.
        /// </summary>
        public int TipoServId { get; set; }
        /// <summary>
        /// Identificação da solicitação de serviço.
        /// </summary>
        public long SolicServId { get; set; }
        /// <summary>
        /// Situação da solicitação do serviço (Em Análise, Deferido ou Indeferido).
        /// </summary>
        public string? SolicTipoServSituacaoSolic { get; set; }
        /// <summary>
        /// Situação da execução do serviço (Executado ou Não Executado).
        /// Situação da execução do serviço (Executado ou Não Executado)
        /// 
        /// </summary>
        public string? SolicTipoServSituacaoExec { get; set; }
        /// <summary>
        /// Data da solicitação do serviço.
        /// Data da solicitação do serviço.
        /// 
        /// </summary>
        public DateTime? SolicTipoServDataSolic { get; set; }
        /// <summary>
        /// Data da execução do serviço.
        /// Data da execução do serviço.
        /// 
        /// </summary>
        public DateTime? SolicTipoServDataExec { get; set; }
        /// <summary>
        /// Dados complementares sobre o serviço.
        /// </summary>
        public string? SolicTipoServHistorico { get; set; }

        public virtual AguaReqSolicitacaoServico SolicServ { get; set; } = null!;
        public virtual AguaTiposServAgua TipoServ { get; set; } = null!;
        public virtual ICollection<AguaReqSolicServParc> AguaReqSolicServParcs { get; set; }
    }
}
