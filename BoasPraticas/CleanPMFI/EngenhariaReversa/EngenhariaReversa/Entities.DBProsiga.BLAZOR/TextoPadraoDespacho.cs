using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class TextoPadraoDespacho
    {
        /// <summary>
        /// Identificação do Texto Padrão do Despacho
        /// </summary>
        public int TextoPadDespId { get; set; }
        /// <summary>
        /// Descrição do texto padrão do despacho
        /// </summary>
        public string? TextoPadrao { get; set; }
    }
}
