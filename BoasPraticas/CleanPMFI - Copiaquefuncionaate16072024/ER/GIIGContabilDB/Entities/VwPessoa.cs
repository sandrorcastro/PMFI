using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class VwPessoa
{
    public int IdPessoa { get; set; }

    public string? NrCnpjcpf { get; set; }

    public string? NmPessoa { get; set; }

    public string? NmFantasia { get; set; }

    public string? DsCep { get; set; }

    public string? DsComplEndereco { get; set; }

    public string? NrPredial { get; set; }

    public string? NrRgIe { get; set; }

    public string? DsufExp { get; set; }

    public string NrCc { get; set; } = null!;

    public string NrAg { get; set; } = null!;

    public DateTime DtInclusao { get; set; }

    public string? NrTelefones { get; set; }

    public string NrFax { get; set; } = null!;

    public decimal VlCapitalSocial { get; set; }

    public string? DsAtividade { get; set; }

    public string? NrRegistroJuntaComercial { get; set; }

    public string? DsEmail { get; set; }

    public string? DsSite { get; set; }

    public int NrCmc { get; set; }

    public string? DsTipo { get; set; }

    public string? NmLogradouro { get; set; }

    public string? NmBairro { get; set; }

    public string? NmCidade { get; set; }

    public string? DsUf { get; set; }

    public string? DsOrgaoExp { get; set; }
}
