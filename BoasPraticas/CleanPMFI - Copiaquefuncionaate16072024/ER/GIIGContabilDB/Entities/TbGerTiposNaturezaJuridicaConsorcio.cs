using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbGerTiposNaturezaJuridicaConsorcio
{
    public short IdTipoNaturezaJuridica { get; set; }

    public string? DsTipoNaturezaJuridica { get; set; }

    public virtual ICollection<TbGerConsorciosMunicipio> TbGerConsorciosMunicipios { get; set; } = new List<TbGerConsorciosMunicipio>();
}
