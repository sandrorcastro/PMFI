using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribPortalCaixaEntradum
{
    public int Cxid { get; set; }

    public long? ContadorId { get; set; }

    public long? ConId { get; set; }

    public int? Msgid { get; set; }

    public DateTime? CxDataLeitura { get; set; }

    public virtual TribContador? Contador { get; set; }

    public virtual TribPortalMensagem? Msg { get; set; }
}
