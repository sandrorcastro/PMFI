using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribDocumento
{
    public int IdDocumento { get; set; }

    public int? NrSequencia { get; set; }

    public short? NrAno { get; set; }

    public int? IdTipoDoc { get; set; }

    public byte[]? ImDocumento { get; set; }

    public virtual TribDocumentosTipo? IdTipoDocNavigation { get; set; }
}
