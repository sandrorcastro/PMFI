using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbSysNumeraObjetoTce
{
    public int IdNumeracao { get; set; }

    public short? IdEmpresa { get; set; }

    public int? NrSequencia { get; set; }

    public short? NrAno { get; set; }

    public DateTime? DtNumeracao { get; set; }

    public int? IdTabela { get; set; }

    public string? NmTabela { get; set; }

    public string? TpNumeracao { get; set; }
}
