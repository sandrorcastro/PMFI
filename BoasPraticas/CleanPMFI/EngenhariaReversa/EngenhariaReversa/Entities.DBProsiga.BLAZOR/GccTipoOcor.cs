using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class GccTipoOcor
    {
        public GccTipoOcor()
        {
            GccMovtoOcors = new HashSet<GccMovtoOcor>();
        }

        public string TocorCnpjmembro { get; set; } = null!;
        public int TocorId { get; set; }
        public string? TocorDescr { get; set; }

        public virtual ICollection<GccMovtoOcor> GccMovtoOcors { get; set; }
    }
}
