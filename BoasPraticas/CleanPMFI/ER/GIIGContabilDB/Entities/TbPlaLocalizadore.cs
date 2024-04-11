using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbPlaLocalizadore
{
    public int IdLocalizador { get; set; }

    public string? NmLocalizador { get; set; }

    public virtual ICollection<TbPlaObjetivosMetasLocalizadore> TbPlaObjetivosMetasLocalizadores { get; set; } = new List<TbPlaObjetivosMetasLocalizadore>();
}
