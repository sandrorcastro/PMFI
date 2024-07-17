using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbIpmOrgaoFolha
{
    public short IdOrgao { get; set; }

    public short? NrPoder { get; set; }

    public string? NmOrgao { get; set; }

    public string? NrCnpj { get; set; }

    public string? DsEndereco { get; set; }

    public string? DsBairro { get; set; }

    public string? DsCep { get; set; }

    public string? NrTelefone { get; set; }

    public string? NrFax { get; set; }

    public string? DsEmail { get; set; }

    public string? NmResponsavel { get; set; }

    public string? NrTelefoneResponsavel { get; set; }

    public string? NrFaxResponsavel { get; set; }

    public string? DsEmailResponsavel { get; set; }
}
