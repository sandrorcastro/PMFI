using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbDspSetoresCompra
{
    public short IdSetorCompra { get; set; }

    public short? IdEmpresa { get; set; }

    public string? NmSetorCompra { get; set; }

    public bool? FlCpl { get; set; }

    public virtual ICollection<TbDspRm> TbDspRms { get; set; } = new List<TbDspRm>();

    public virtual ICollection<TbDspSetoresCompraOrgaosUnidade> TbDspSetoresCompraOrgaosUnidades { get; set; } = new List<TbDspSetoresCompraOrgaosUnidade>();

    public virtual ICollection<TbLicLicitaco> TbLicLicitacos { get; set; } = new List<TbLicLicitaco>();

    public virtual ICollection<TbLicModalidade> IdModalidades { get; set; } = new List<TbLicModalidade>();
}
