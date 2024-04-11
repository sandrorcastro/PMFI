using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbDspDocumento
{
    public int IdDocumento { get; set; }

    public string? DsDocumento { get; set; }

    public byte[]? BnDocumento { get; set; }

    public string? DsExtensao { get; set; }

    public DateTime? DtInclusao { get; set; }

    public string? DsLogin { get; set; }

    public virtual ICollection<TbDspDocumentosTransaco> TbDspDocumentosTransacos { get; set; } = new List<TbDspDocumentosTransaco>();
}
