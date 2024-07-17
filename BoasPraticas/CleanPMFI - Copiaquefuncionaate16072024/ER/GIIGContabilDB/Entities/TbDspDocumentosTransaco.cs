using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbDspDocumentosTransaco
{
    public int IdDocumento { get; set; }

    public string DsTransacao { get; set; } = null!;

    public int NrTransacao { get; set; }

    public string? DsLogin { get; set; }

    public DateTime? DtInclusao { get; set; }

    public virtual TbDspDocumento IdDocumentoNavigation { get; set; } = null!;
}
