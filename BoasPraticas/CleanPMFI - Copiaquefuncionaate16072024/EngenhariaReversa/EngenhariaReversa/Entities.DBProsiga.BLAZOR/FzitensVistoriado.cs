using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class FzitensVistoriado
    {
        /// <summary>
        /// Código de Identificação do Item Vistoriado do Veiculo
        /// </summary>
        public int ItemVistoriadoId { get; set; }
        /// <summary>
        /// Código de Identificação da Vistoria do Veiculo
        /// </summary>
        public long VistId { get; set; }
        /// <summary>
        /// Código de Identificação do Item 
        /// </summary>
        public int ItemVistId { get; set; }
        /// <summary>
        /// Outras Informações a respeito do Item Vistoriado
        /// </summary>
        public string? Vvobs { get; set; }

        public virtual FzitensDeVistorium ItemVist { get; set; } = null!;
        public virtual FzvistoriaVeiculo Vist { get; set; } = null!;
    }
}
