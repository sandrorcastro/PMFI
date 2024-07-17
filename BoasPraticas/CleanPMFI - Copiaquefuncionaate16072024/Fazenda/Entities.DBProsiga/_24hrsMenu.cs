using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class _24hrsMenu
{
    public int Idmenu { get; set; }

    public string Titulo { get; set; } = null!;

    public string Nomeguia { get; set; } = null!;

    public string? Texto { get; set; }

    public string? Link { get; set; }

    public string? LinkFoto { get; set; }

    public string? Visivel { get; set; }

    public short? Ordem { get; set; }

    public virtual _24hrsGuia NomeguiaNavigation { get; set; } = null!;
}
