using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TbEmpAtributosDinamico
{
    public int IdAtributo { get; set; }

    public string? DsAtributo { get; set; }

    public string? DsTipoAtributo { get; set; }

    public string? DsValoresValidos { get; set; }

    public virtual ICollection<TribEmpresasAtivAtributo> TribEmpresasAtivAtributos { get; set; } = new List<TribEmpresasAtivAtributo>();
}
