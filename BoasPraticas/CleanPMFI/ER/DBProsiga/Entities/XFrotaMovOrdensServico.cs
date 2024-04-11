using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class XFrotaMovOrdensServico
{
    public long XFmovOsid { get; set; }

    public long? XFmovOsnum { get; set; }

    public int? XFmovOsdivisao { get; set; }

    public DateTime? XFmovOsdata { get; set; }

    public int? XFmovOskmInicial { get; set; }

    public int? XFmovOskmFinal { get; set; }

    public string? XFmovOshistorico { get; set; }

    public long? XFrotaOsidCondut { get; set; }

    public virtual XFrotaOrdensServico? XFmovOsnumNavigation { get; set; }

    public virtual Condutores1registro? XFrotaOsidCondutNavigation { get; set; }
}
