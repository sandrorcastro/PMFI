using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class TribEdifCartoriosVendedore
{
    public int IdcartorioVendedor { get; set; }

    public int? IdedifCartorio { get; set; }

    public long? ConId { get; set; }

    public string? DsCpfcnpj { get; set; }

    public string? DsNome { get; set; }
}
