using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class AguaReqSolicServParc
    {
        public AguaReqSolicServParc()
        {
            AguaDividasServAguas = new HashSet<AguaDividasServAgua>();
        }

        public long SolicServParcId { get; set; }
        /// <summary>
        /// Identificação do tipo de servico da agua.
        /// </summary>
        public int TipoServId { get; set; }
        /// <summary>
        /// Identificação da solicitação de serviço.
        /// </summary>
        public long SolicServId { get; set; }
        /// <summary>
        /// Número de parcelas.
        /// </summary>
        public int? SolicServParcParcela { get; set; }
        /// <summary>
        /// Mês da parcela.
        /// </summary>
        public int? SolicServParcMes { get; set; }
        /// <summary>
        /// Ano da parcela.
        /// </summary>
        public int? SolicServParcAno { get; set; }

        public virtual AguaReqSolicServTipoServ AguaReqSolicServTipoServ { get; set; } = null!;
        public virtual ICollection<AguaDividasServAgua> AguaDividasServAguas { get; set; }
    }
}
