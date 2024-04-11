using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbLdoDemRiscosFiscai
{
    public int IdDemRiscosFiscais { get; set; }

    public int? IdVersaoRisco { get; set; }

    public short? NrAno { get; set; }

    public short? IdRisco { get; set; }

    public short? NrProvidencia { get; set; }

    public decimal? VlEstimadoRisco { get; set; }

    public string? DsProvidencia { get; set; }

    public decimal? VlEstimadoProvidencia { get; set; }

    public virtual TbLdoTiposPassivosRisco? IdRiscoNavigation { get; set; }
}
