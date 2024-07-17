using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
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
