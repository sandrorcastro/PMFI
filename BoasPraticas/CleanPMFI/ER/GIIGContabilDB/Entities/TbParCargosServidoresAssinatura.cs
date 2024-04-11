using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbParCargosServidoresAssinatura
{
    public int IdCargoServidor { get; set; }

    public string DsDocumento { get; set; } = null!;

    public short? NrSequencia { get; set; }

    public bool? FlAssinaDocumento { get; set; }

    public string? DsCargo { get; set; }

    public virtual TbGerCargosServidore IdCargoServidorNavigation { get; set; } = null!;
}
