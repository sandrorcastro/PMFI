using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class SaudeAc
{
    public int Idacs { get; set; }

    public int? Idpsf { get; set; }

    public string? NomeAcs { get; set; }

    public string? Telefones { get; set; }

    public int? Idendereco { get; set; }

    public string? NrPredial { get; set; }

    public string? Complemento { get; set; }

    public string? Cpf { get; set; }

    public string? Rg { get; set; }

    public DateTime? Data { get; set; }

    public string? Situacao { get; set; }
}
