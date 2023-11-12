using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class Tbtribtipoempresadocumento
{
    public short Idtipoempresa { get; set; }

    public short Iddocumento { get; set; }

    public bool Flativo { get; set; }

    public virtual TribAtivDocumento IddocumentoNavigation { get; set; } = null!;

    public virtual Tbtribtipoempresa IdtipoempresaNavigation { get; set; } = null!;
}
