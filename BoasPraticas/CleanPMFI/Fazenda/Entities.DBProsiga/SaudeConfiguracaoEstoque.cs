using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class SaudeConfiguracaoEstoque
{
    public int CdEstoque { get; set; }

    public int CdMedicamento { get; set; }

    public int? QtdEstoqueMin { get; set; }

    public int? QtdEstoqueMax { get; set; }
}
