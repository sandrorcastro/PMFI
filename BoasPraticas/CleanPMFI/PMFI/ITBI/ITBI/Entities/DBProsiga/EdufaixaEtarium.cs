using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class EdufaixaEtarium
{
    public long FxEtId { get; set; }

    public int? FxEtDe { get; set; }

    public int? FxEtAte { get; set; }

    public virtual ICollection<EduturmaMe> EduturmaMes { get; set; } = new List<EduturmaMe>();
}
