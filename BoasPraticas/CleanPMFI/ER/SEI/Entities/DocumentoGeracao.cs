using System;
using System.Collections.Generic;

namespace SEI.Entities;

public partial class DocumentoGeracao
{
    public long IdDocumento { get; set; }

    public long? IdDocumentoModelo { get; set; }

    public int? IdTextoPadraoInterno { get; set; }

    public virtual Documento IdDocumentoNavigation { get; set; } = null!;
}
