using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TribAcrescimo
    {
        public long AcrescId { get; set; }
        public DateTime? AcrescDe { get; set; }
        public DateTime? AcrescAte { get; set; }
        public decimal? AcrescMulta { get; set; }
        public decimal? AcrescMulta30 { get; set; }
        public decimal? AcrescMulta60 { get; set; }
        public decimal? AcrescJuros { get; set; }
        public decimal? AcrescMultaDa { get; set; }
        /// <summary>
        /// Informa se a multa é proporcional aos dias vencido (so multa e nao multa 30/60)
        /// </summary>
        public string AcrescMultaPropDiasVencido { get; set; } = null!;
        /// <summary>
        /// Tipo de Juros = &apos;Mensal&apos; ou Diário
        /// </summary>
        public string AcrescTipoJuros { get; set; } = null!;
        /// <summary>
        /// Moeda utilizada na Correção dos Acrescimos
        /// </summary>
        public short AcrescMoedaCorrecao { get; set; }
        /// <summary>
        /// Apos esta data o sistema não irá calcular correção para as dividas (axo)
        /// </summary>
        public DateTime? AcrescCorrigirDividasAte { get; set; }
        public string? AcrescTipoCorrecao { get; set; }
    }
}
