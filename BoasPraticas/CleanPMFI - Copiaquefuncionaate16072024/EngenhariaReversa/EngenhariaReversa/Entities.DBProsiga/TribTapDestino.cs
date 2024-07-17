using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class TribTapDestino
    {
        public long TapDestinoId { get; set; }
        public long? TapId { get; set; }
        /// <summary>
        /// Código de identificação da dívida.
        /// </summary>
        public long? ImoIddivida { get; set; }
        public long? ConIddivida { get; set; }
        public long? EmpIddivida { get; set; }
        public decimal? TapDestVlrPrinc { get; set; }
        public decimal? TapDestVlrJuros { get; set; }
        public decimal? TapDestVlrMulta { get; set; }
        public decimal? TapDestVlrCorrec { get; set; }
        public decimal? TapDestVlrDesc { get; set; }
        public decimal? TapDestVlrMultaDa { get; set; }
        /// <summary>
        /// Este campo é sincronizado por Trigger
        /// </summary>
        public int? TipoBxId { get; set; }
        public string? UsuarioInclusao { get; set; }
        public DateTime? DataInclusao { get; set; }
        public decimal? TapDestVlrEntrada { get; set; }
        public decimal? TapDestPercRescisao { get; set; }

        public virtual TribDividasContribuinte? ConIddividaNavigation { get; set; }
        public virtual TribDividasEmpresa? EmpIddividaNavigation { get; set; }
        public virtual TribDividasImo? ImoIddividaNavigation { get; set; }
        public virtual TribTap? Tap { get; set; }
        public virtual TribTipoBaixa? TipoBx { get; set; }
    }
}
