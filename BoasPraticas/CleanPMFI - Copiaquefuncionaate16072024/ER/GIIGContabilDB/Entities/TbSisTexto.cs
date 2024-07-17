using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbSisTexto
{
    public int IdTexto { get; set; }

    public short? IdEmpresa { get; set; }

    public string? DsTitulo { get; set; }

    public string? DsTexto { get; set; }

    public string? DsObservacao { get; set; }

    public string? NmTexto { get; set; }

    public short? NrAno { get; set; }
}
