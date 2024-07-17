using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class SisFormataCampo
    {
        /// <summary>
        /// Nome do tipo de formatação, ex.: InscricaoImobiliaria (10132320237001).
        /// </summary>
        public string SifoTipoFormatacao { get; set; } = null!;
        /// <summary>
        /// Nome do campo que será formatado. Ex.: Quadrante, Quadricula, Setor e etc...
        /// </summary>
        public string SifoDescrNomeCampo { get; set; } = null!;
        /// <summary>
        /// Marca o início para realização do MID no campo.
        /// </summary>
        public byte SifoInicioFormatacao { get; set; }
        /// <summary>
        /// Marca o tamanho que deverá ser retirando da string com MID.
        /// </summary>
        public byte? SifoTamanhoFormatacao { get; set; }
    }
}
