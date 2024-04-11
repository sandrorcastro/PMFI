using System;
using System.Collections.Generic;

namespace GIIGSystemDB.Entities;

public partial class TbGerAgendaTarefa
{
    public int IdTarefa { get; set; }

    public int? IdEmpresa { get; set; }

    public string? NmTarefa { get; set; }

    public string? DsTarefa { get; set; }

    public int? IdFormulario { get; set; }

    public string? DsSituacao { get; set; }

    public DateTime? DtTermino { get; set; }

    public DateTime? DtInclusao { get; set; }

    public string? DsLogin { get; set; }
}
