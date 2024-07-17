using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribCertidaoDaversao
{
    public long IdVersaoCda { get; set; }

    public long? CertidaoDaid { get; set; }

    public DateTime? DtVersao { get; set; }

    public string? DsLogin { get; set; }

    public bool? FlOriginal { get; set; }

    public virtual TribCertidaoDum? CertidaoDa { get; set; }

    public virtual ICollection<TribProtestoLoteCdum> TribProtestoLoteCda { get; set; } = new List<TribProtestoLoteCdum>();
}
