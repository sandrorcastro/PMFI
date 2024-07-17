using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbStnFontePadrao
{
    public int CdFontePadraoStn { get; set; }

    public string? DsFontePadraoStn { get; set; }

    public string? DsEspecificação { get; set; }

    public virtual ICollection<TbStnMarcador> CdMarcadorStns { get; set; } = new List<TbStnMarcador>();
}
