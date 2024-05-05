using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class GccCompFamiliar
{
    public string CompCnpjmembro { get; set; } = null!;

    public long CompCriId { get; set; }

    public int CompSeqId { get; set; }

    public string? CompNome { get; set; }

    public string? CompParentesco { get; set; }

    public string? CompProfissao { get; set; }

    public decimal? CompRenda { get; set; }

    public string? CompLocalTrabalho { get; set; }

    public string? CompTelLocTrab { get; set; }

    public string? CompCelular { get; set; }

    public string? CompRua { get; set; }

    public string? CompBairro { get; set; }

    public string? CompComplemento { get; set; }

    public string? CompCidade { get; set; }

    public string? CompUf { get; set; }

    public virtual GccCrianca GccCrianca { get; set; } = null!;
}
