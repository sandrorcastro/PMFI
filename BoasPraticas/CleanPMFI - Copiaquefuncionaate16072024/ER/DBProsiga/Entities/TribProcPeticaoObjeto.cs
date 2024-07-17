using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribProcPeticaoObjeto
{
    public int ProcObjId { get; set; }

    public long ProcPetId { get; set; }

    public int ObjetoId { get; set; }

    public int? TipoObjetoId { get; set; }

    public string? ProcObjNumero { get; set; }

    public string? ProcObjResumo { get; set; }
}
