using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TribTipoDividum
    {
        public TribTipoDividum()
        {
            TribDividasImos = new HashSet<TribDividasImo>();
            TribProtestoLoteCdahistoricoSituacaoDividumTipoDivIddestinoNavigations = new HashSet<TribProtestoLoteCdahistoricoSituacaoDividum>();
            TribProtestoLoteCdahistoricoSituacaoDividumTipoDivIdorigemNavigations = new HashSet<TribProtestoLoteCdahistoricoSituacaoDividum>();
            TribLeisDescTributos = new HashSet<TribLeisDescTributo>();
        }

        public int TipoDivId { get; set; }
        public string? TipoDivNome { get; set; }
        /// <summary>
        /// Informa se o tipo da divida pode ser feito parcelamento pelo REFIS
        /// </summary>
        public string TipoDivUsaCertidao { get; set; } = null!;

        public virtual ICollection<TribDividasImo> TribDividasImos { get; set; }
        public virtual ICollection<TribProtestoLoteCdahistoricoSituacaoDividum> TribProtestoLoteCdahistoricoSituacaoDividumTipoDivIddestinoNavigations { get; set; }
        public virtual ICollection<TribProtestoLoteCdahistoricoSituacaoDividum> TribProtestoLoteCdahistoricoSituacaoDividumTipoDivIdorigemNavigations { get; set; }

        public virtual ICollection<TribLeisDescTributo> TribLeisDescTributos { get; set; }
    }
}
