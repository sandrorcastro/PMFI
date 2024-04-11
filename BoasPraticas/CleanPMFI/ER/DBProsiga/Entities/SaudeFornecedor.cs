using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class SaudeFornecedor
{
    public int IdFornecedor { get; set; }

    public string? RazaoSocial { get; set; }

    public string? NomeContato { get; set; }

    public string? CpfCnpj { get; set; }

    public string? Email { get; set; }

    public string? Telefone { get; set; }

    public int? IdEndereco { get; set; }

    public string? NroPredial { get; set; }

    public string? Complemento { get; set; }

    public string? NomeFantasia { get; set; }
}
