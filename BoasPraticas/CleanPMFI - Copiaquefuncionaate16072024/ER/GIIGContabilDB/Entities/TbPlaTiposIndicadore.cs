using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbPlaTiposIndicadore
{
    public int IdTipoIndicador { get; set; }

    public int? CdTipoIndicador { get; set; }

    public string? DsTipoIndicador { get; set; }

    public string? DsSiglaTipo { get; set; }

    public string? IdNaturezasIndicador { get; set; }

    public virtual ICollection<TbPlaIndicadoresMovimento> TbPlaIndicadoresMovimentos { get; set; } = new List<TbPlaIndicadoresMovimento>();
}
