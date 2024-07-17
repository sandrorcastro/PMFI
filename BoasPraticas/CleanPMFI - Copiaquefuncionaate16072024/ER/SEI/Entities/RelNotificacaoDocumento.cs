using System;
using System.Collections.Generic;

namespace SEI.Entities;

public partial class RelNotificacaoDocumento
{
    public long IdDocumento { get; set; }

    public int IdNotificacao { get; set; }

    public string SinProcessada { get; set; } = null!;

    public virtual Documento IdDocumentoNavigation { get; set; } = null!;

    public virtual Notificacao IdNotificacaoNavigation { get; set; } = null!;
}
