using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbGerTiposAreaConsorcio
{
    public short IdTipoAreaConsorcio { get; set; }

    public string? DsTipoAreaConsorcio { get; set; }

    public virtual ICollection<TbGerConsorciosMunicipio> TbGerConsorciosMunicipios { get; set; } = new List<TbGerConsorciosMunicipio>();
}
