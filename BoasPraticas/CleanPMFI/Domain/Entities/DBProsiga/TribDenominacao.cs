using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TribDenominacao
    {
        public TribDenominacao()
        {
            TribEdificacos = new HashSet<TribEdificaco>();
        }

        public long DenoId { get; set; }
        public string? DenoNome { get; set; }
        public byte[]? DenoImagem { get; set; }
        /// <summary>
        /// Padrão do Prédio
        /// </summary>
        public int? DenoPadrao { get; set; }
        /// <summary>
        /// Construtora
        /// </summary>
        public string? DenoConstrutora { get; set; }
        /// <summary>
        /// Numero de pavimentos (andares)
        /// </summary>
        public int? DenoPavimentos { get; set; }
        public string? DenoDataConstrucao { get; set; }
        /// <summary>
        /// Numero de Elevadores
        /// </summary>
        public int? DenoElevadores { get; set; }
        /// <summary>
        /// Codigo do CANADAS para conversão
        /// </summary>
        public string? DenoCodigoCanadas { get; set; }
        /// <summary>
        /// Bloco - Conversão CANADAS
        /// </summary>
        public string? DenoBloco { get; set; }
        public DateTime? Datatemp { get; set; }

        public virtual ICollection<TribEdificaco> TribEdificacos { get; set; }
    }
}
