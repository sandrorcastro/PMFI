﻿using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbPlaMacroObjetivo
{
    public int IdMacroObjetivo { get; set; }

    public string? CdMacroObjetivo { get; set; }

    public int? IdVersaoCriacao { get; set; }

    public string? NmMacroObjetivo { get; set; }

    public string? DsMacroObjetivo { get; set; }

    public short IdObjetivoMilenio { get; set; }

    public string? TpComando { get; set; }

    public short? IdObjetivoDesenvSustentavel { get; set; }

    public virtual TbPlaObjetivosMilenio IdObjetivoMilenioNavigation { get; set; } = null!;

    public virtual ICollection<TbPlaPrograma> TbPlaProgramas { get; set; } = new List<TbPlaPrograma>();
}
