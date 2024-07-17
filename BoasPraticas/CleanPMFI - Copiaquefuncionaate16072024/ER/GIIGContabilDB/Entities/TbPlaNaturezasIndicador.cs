using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbPlaNaturezasIndicador
{
    public string IdNaturezaIndicador { get; set; } = null!;

    public string? DsNaturezaIndicador { get; set; }

    public virtual ICollection<TbPlaIndicadoresMovimento> TbPlaIndicadoresMovimentos { get; set; } = new List<TbPlaIndicadoresMovimento>();
}
