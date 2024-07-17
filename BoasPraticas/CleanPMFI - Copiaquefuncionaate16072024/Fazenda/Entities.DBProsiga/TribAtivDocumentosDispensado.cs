using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class TribAtivDocumentosDispensado
{
    public short Iddocumento { get; set; }

    public short Iddocumentodispensado { get; set; }

    public string Dsmotivo { get; set; } = null!;

    public virtual TribAtivDocumento IddocumentoNavigation { get; set; } = null!;

    public virtual TribAtivDocumento IddocumentodispensadoNavigation { get; set; } = null!;
}
