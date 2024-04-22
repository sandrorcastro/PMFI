using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class EdufaixaEtarium
    {
        public EdufaixaEtarium()
        {
            EduturmaMes = new HashSet<EduturmaMe>();
        }

        public long FxEtId { get; set; }
        public int? FxEtDe { get; set; }
        public int? FxEtAte { get; set; }

        public virtual ICollection<EduturmaMe> EduturmaMes { get; set; }
    }
}
