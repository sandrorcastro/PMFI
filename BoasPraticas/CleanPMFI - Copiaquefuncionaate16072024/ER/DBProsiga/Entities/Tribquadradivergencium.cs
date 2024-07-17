using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class Tribquadradivergencium
{
    public int Idquadradivergencia { get; set; }

    public int? Idquadra { get; set; }

    public int? Iddivergencia { get; set; }

    public string? Dsobservacao { get; set; }

    public virtual Tbrevisaodivergencium? IddivergenciaNavigation { get; set; }

    public virtual TribQuadra? IdquadraNavigation { get; set; }
}
