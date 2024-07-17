using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class AguaRateio
    {
        /// <summary>
        /// Identificação exclusiva do rateio.
        /// Identificação exclusiva do rateio.
        /// 
        /// </summary>
        public int RateioId { get; set; }
        /// <summary>
        /// Código de Identificação do Rateio.
        /// </summary>
        public int? HidroId { get; set; }
        /// <summary>
        /// Código de Identificação da Categoria.
        /// </summary>
        public int? CategId { get; set; }
        /// <summary>
        /// Data inicio da validade.
        /// Data inicio da validade.
        /// 
        /// </summary>
        public DateTime? RateioDataIni { get; set; }
        /// <summary>
        /// Data final da validade do registro.
        /// 
        /// </summary>
        public DateTime? RateioDataFim { get; set; }
        /// <summary>
        /// Histórico do lançamento.
        /// 
        /// </summary>
        public string? RateioHistorico { get; set; }

        public virtual AguaHidrometro? Hidro { get; set; }
    }
}
