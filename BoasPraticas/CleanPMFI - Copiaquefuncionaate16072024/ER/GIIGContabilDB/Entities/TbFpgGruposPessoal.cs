using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbFpgGruposPessoal
{
    public short IdGrupo { get; set; }

    public string? DsGrupo { get; set; }

    public virtual ICollection<TbFpgGrupoPessoalNatureza> TbFpgGrupoPessoalNaturezas { get; set; } = new List<TbFpgGrupoPessoalNatureza>();
}
