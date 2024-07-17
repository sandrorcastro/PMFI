using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class LocTipoPagto
    {
        public LocTipoPagto()
        {
            Locacaos = new HashSet<Locacao>();
        }

        public int TipoPagtoId { get; set; }
        public string? TipoPdescricao { get; set; }
        public string? TipoPtecUltAlt { get; set; }
        public DateTime? TipoPdtUltAlt { get; set; }

        public virtual ICollection<Locacao> Locacaos { get; set; }
    }
}
