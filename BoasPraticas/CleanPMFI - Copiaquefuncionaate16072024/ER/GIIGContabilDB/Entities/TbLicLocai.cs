using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbLicLocai
{
    public short IdLocal { get; set; }

    public string? NmLocal { get; set; }

    public int? IdEndereco { get; set; }

    public int? NrPredial { get; set; }

    public string? DsComplementoEndereco { get; set; }

    public string? NrFone { get; set; }

    public string? NmContato { get; set; }

    public string? NmNomeSetor { get; set; }

    public string? DsEmail { get; set; }

    public string? DsSite { get; set; }

    public virtual TbGerEndereco? IdEnderecoNavigation { get; set; }

    public virtual ICollection<TbLicLicitaco> TbLicLicitacos { get; set; } = new List<TbLicLicitaco>();
}
