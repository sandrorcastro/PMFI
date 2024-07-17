using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class TribRequerimentoDivOrigem
    {
        public TribRequerimentoDivOrigem()
        {
            TribRequerimentoDivDesmembrada = new HashSet<TribRequerimentoDivDesmembradum>();
        }

        public long ReqOrigemId { get; set; }
        public long RequerId { get; set; }
        public long ImoIddivida { get; set; }
        /// <summary>
        /// Impostos, Taxas ou Impostos e Taxas
        /// </summary>
        public string? ReqOrigemTipoIsencao { get; set; }
        /// <summary>
        /// Em análise, Deferido ou Indeferido
        /// </summary>
        public string? ReqOrigemSituacao { get; set; }

        public virtual TribDividasImo ImoIddividaNavigation { get; set; } = null!;
        public virtual TribRequerimento Requer { get; set; } = null!;
        public virtual ICollection<TribRequerimentoDivDesmembradum> TribRequerimentoDivDesmembrada { get; set; }
    }
}
