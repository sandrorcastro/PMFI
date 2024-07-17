using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbStnMarcador
{
    public string CdMarcadorStn { get; set; } = null!;

    public string? DsMarcadorStn { get; set; }

    public string? DsEspecificação { get; set; }

    public virtual ICollection<TbStnFontePadrao> CdFontePadraoStns { get; set; } = new List<TbStnFontePadrao>();
}
