using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class Tbrevisaodivergencium
{
    public int Iddivergencia { get; set; }

    public string Dsdivergencia { get; set; } = null!;

    public virtual ICollection<Tribedificacoesdivergencium> Tribedificacoesdivergencia { get; set; } = new List<Tribedificacoesdivergencium>();

    public virtual ICollection<Tribquadradivergencium> Tribquadradivergencia { get; set; } = new List<Tribquadradivergencium>();
}
