using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class TempVoltarVencimento
{
    public double? ImoIddivida { get; set; }

    public double? EdificacaoId { get; set; }

    public double? ImoDivAno { get; set; }

    public double? ImoDivParcela { get; set; }

    public double? Contador { get; set; }

    public string? ImoDivVencimento { get; set; }

    public DateTime? VencimentoFormatado { get; set; }

    public string? Script { get; set; }
}
