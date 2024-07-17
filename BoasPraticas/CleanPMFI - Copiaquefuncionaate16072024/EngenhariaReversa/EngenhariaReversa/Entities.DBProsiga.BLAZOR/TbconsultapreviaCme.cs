using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class TbconsultapreviaCme
    {
        public int Idconsultacme { get; set; }
        /// <summary>
        /// ID da Consulta Prévia
        /// </summary>
        public int Idconsulta { get; set; }
        /// <summary>
        /// Data da Geração do CME Municipal (Automática)
        /// </summary>
        public DateTime Dtgeracao { get; set; }
        /// <summary>
        /// Parecer do Servidor que efetuou a geração.
        /// </summary>
        public string Dsparecer { get; set; } = null!;
        /// <summary>
        /// Número do CME Gerado.
        /// </summary>
        public int? EmprCme { get; set; }
    }
}
