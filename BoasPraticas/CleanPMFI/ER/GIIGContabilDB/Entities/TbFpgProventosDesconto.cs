using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbFpgProventosDesconto
{
    public int IdDesconto { get; set; }

    public int IdProvento { get; set; }

    public string? DsContaContabil { get; set; }

    public string? NrCnpjcpffavorecido { get; set; }

    public decimal? VlDesconto { get; set; }

    public int? IdRecurso { get; set; }

    public string? DsDesconto { get; set; }

    public string? DsErro { get; set; }

    public DateTime? DtInclusao { get; set; }

    public string? DsLogin { get; set; }

    public int? IdCcorigem { get; set; }

    public short? IdTipoDocFinanceiro { get; set; }

    public virtual TbFpgProvento IdProventoNavigation { get; set; } = null!;
}
