using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbWflAnexo
{
    public int IdAnexo { get; set; }

    public DateTime? DtAnexo { get; set; }

    public byte[]? ImAnexo { get; set; }

    public string? DsAnexo { get; set; }

    public string? DsTipoAnexo { get; set; }

    public string? DsExtensaoAnexo { get; set; }

    public string? DsLogin { get; set; }

    public int? IdRemessa { get; set; }

    public virtual TbWflRemessa? IdRemessaNavigation { get; set; }
}
