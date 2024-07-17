using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class AguaReqSolicitacaoServico
    {
        public AguaReqSolicitacaoServico()
        {
            AguaReqSolicServTipoServs = new HashSet<AguaReqSolicServTipoServ>();
        }

        /// <summary>
        /// Código de identificação exclusiva.
        /// Identificação do texto para o corpo do documento.
        /// </summary>
        public long SolicServId { get; set; }
        /// <summary>
        /// Identificação do texto para o corpo do documento.
        /// </summary>
        public long? TextoId { get; set; }
        /// <summary>
        /// Identificação do numero do protocolo (a princípio não esta integrado com protocolo geral).
        /// 
        /// </summary>
        public int? ProtocoloId { get; set; }
        /// <summary>
        /// Identificação do contribuinte que esta solicitando o serviço.
        /// </summary>
        public long? ConId { get; set; }
        /// <summary>
        /// Identificação do hidrometro que ira receber o serviço.
        /// </summary>
        public int? HidroId { get; set; }
        /// <summary>
        /// Data da solicitação.
        /// 
        /// </summary>
        public DateTime? SolicServDataSolicit { get; set; }
        public int? SolicServParcela { get; set; }
        public int? SolicServMesParc { get; set; }
        public int? SolicServAnoParc { get; set; }
        /// <summary>
        /// Dados complementares da solicitação.
        /// </summary>
        public string? SolicServHistorico { get; set; }

        public virtual Contribuinte? Con { get; set; }
        public virtual AguaHidrometro? Hidro { get; set; }
        public virtual TribTexto? Texto { get; set; }
        public virtual ICollection<AguaReqSolicServTipoServ> AguaReqSolicServTipoServs { get; set; }
    }
}
