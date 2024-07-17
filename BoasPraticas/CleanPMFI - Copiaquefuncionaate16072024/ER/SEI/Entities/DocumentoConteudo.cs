using System;
using System.Collections.Generic;

namespace SEI.Entities;

public partial class DocumentoConteudo
{
    public long IdDocumento { get; set; }

    public string? Conteudo { get; set; }

    public string? ConteudoAssinatura { get; set; }

    public string? CrcAssinatura { get; set; }

    public string? QrCodeAssinatura { get; set; }

    public virtual Documento IdDocumentoNavigation { get; set; } = null!;
}
