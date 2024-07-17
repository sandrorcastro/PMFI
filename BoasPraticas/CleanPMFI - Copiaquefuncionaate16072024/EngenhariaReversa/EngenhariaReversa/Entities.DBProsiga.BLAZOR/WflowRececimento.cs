using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class WflowRececimento
    {
        public WflowRececimento()
        {
            Rems = new HashSet<WflowRemessa>();
        }

        public long RecId { get; set; }
        public DateTime? RecData { get; set; }
        public string? UsuId { get; set; }

        public virtual ICollection<WflowRemessa> Rems { get; set; }
    }
}
