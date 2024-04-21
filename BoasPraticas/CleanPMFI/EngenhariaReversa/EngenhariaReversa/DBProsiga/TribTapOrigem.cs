using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TribTapOrigem
    {
        public long TapOrigemId { get; set; }
        public long? TapId { get; set; }
        /// <summary>
        /// Código de identificação da dívida.
        /// </summary>
        public long? ImoIddivida { get; set; }
        public long? ConIddivida { get; set; }
        public long? EmpIddivida { get; set; }
        public decimal? TapOrigVlrPrinc { get; set; }
        public decimal? TapOrigVlrJuros { get; set; }
        public decimal? TapOrigVlrMulta { get; set; }
        public decimal? TapOrigVlrCorrec { get; set; }
        public decimal? TapOrigVlrDesc { get; set; }
        public decimal? TapOrigVlrMultaDa { get; set; }
        public decimal? TapOrigVlrTotal { get; set; }

        public virtual TribDividasContribuinte? ConIddividaNavigation { get; set; }
        public virtual TribDividasEmpresa? EmpIddividaNavigation { get; set; }
        public virtual TribDividasImo? ImoIddividaNavigation { get; set; }
        public virtual TribTap? Tap { get; set; }
    }
}
