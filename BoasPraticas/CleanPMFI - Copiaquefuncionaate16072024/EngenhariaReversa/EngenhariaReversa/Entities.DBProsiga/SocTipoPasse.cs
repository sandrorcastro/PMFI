using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class SocTipoPasse
    {
        public SocTipoPasse()
        {
            SocPasses = new HashSet<SocPasse>();
        }

        public long TpassId { get; set; }
        public string? TpassNome { get; set; }
        public string? TpassDescricao { get; set; }

        public virtual ICollection<SocPasse> SocPasses { get; set; }
    }
}
