using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class TribProtestoLoteCdum
{
    public int IdLote { get; set; }

    public long CertidaoDaid { get; set; }

    public long? IdVersaoCda { get; set; }

    public decimal? VlCdaatualizada { get; set; }

    public DateTime? DtInclusao { get; set; }

    public string? DsUsuarioInclusao { get; set; }

    public string? NrReferencia { get; set; }

    public int IdprotestoLoteCda { get; set; }

    public virtual TribCertidaoDum CertidaoDa { get; set; } = null!;

    public virtual TribProtestoLote IdLoteNavigation { get; set; } = null!;

    public virtual TribCertidaoDaversao? IdVersaoCdaNavigation { get; set; }

    public virtual ICollection<TribProtestoLoteCdacontrib> TribProtestoLoteCdacontribs { get; set; } = new List<TribProtestoLoteCdacontrib>();
}
