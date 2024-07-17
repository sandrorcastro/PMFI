using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbLicModalidade
{
    public short IdModalidade { get; set; }

    public string? DsModalidade { get; set; }

    public string? FlPadraoTce { get; set; }

    public bool? FlNumeraPorNatureza { get; set; }

    public virtual ICollection<TbLicLimite> TbLicLimites { get; set; } = new List<TbLicLimite>();

    public virtual ICollection<TbLicNaturezasProcedimento> TbLicNaturezasProcedimentos { get; set; } = new List<TbLicNaturezasProcedimento>();

    public virtual ICollection<TbDspSetoresCompra> IdSetorCompras { get; set; } = new List<TbDspSetoresCompra>();
}
