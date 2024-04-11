using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class Tbconsultapreviadocumento
{
    public int Idconsulta { get; set; }

    public short Iddocumento { get; set; }

    public bool Flobrigatorio { get; set; }

    public virtual Tbconsultaprevium IdconsultaNavigation { get; set; } = null!;

    public virtual TribAtivDocumento IddocumentoNavigation { get; set; } = null!;
}
