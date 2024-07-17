using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TribTipoTributosTipoProcesso
    {
        public int TipoProId { get; set; }
        public int TipoTribId { get; set; }
        public short? Idmoeda { get; set; }
        public decimal? ValorReferenciaMoeda { get; set; }
        /// <summary>
        /// Quantidade de dias para vencimento a contar da data de abertura do processo no protocolo.
        /// </summary>
        public int? QtdeDiasVenc { get; set; }
        /// <summary>
        /// Marca se as dividas referente ao processo gera automático ou opcional no momento da abetura do processo. Serve para controlar a entidade tribTipoTributosTipoProcesso.
        /// </summary>
        public string? GeraDividasAutomatico { get; set; }

        public virtual TipoProcesso TipoPro { get; set; } = null!;
        public virtual TribTipoTributo TipoTrib { get; set; } = null!;
    }
}
