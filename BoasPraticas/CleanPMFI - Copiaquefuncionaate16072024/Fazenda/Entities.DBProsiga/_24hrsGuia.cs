using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class _24hrsGuia
{
    public string Nomeguia { get; set; } = null!;

    public string? Titulopagina { get; set; }

    public string? Visivel { get; set; }

    public string? Link { get; set; }

    public byte? Ordem { get; set; }

    public virtual ICollection<_24hrsMenu> _24hrsMenus { get; set; } = new List<_24hrsMenu>();
}
