using System;
using System.Collections.Generic;

namespace SEI.Entities;

public partial class AuditoriaProtocolo
{
    public long IdAuditoriaProtocolo { get; set; }

    public long IdProtocolo { get; set; }

    public int IdUsuario { get; set; }

    public int? IdAnexo { get; set; }

    public int? Versao { get; set; }

    public DateTime DtaAuditoria { get; set; }
}
