using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class SaudeConfiguracaoAlmoxarifado
{
    public int CdAlmoxarifado { get; set; }

    public int CdMedicamento { get; set; }

    public int? QtdEstoqueMinimo { get; set; }

    public int? QtdEstoqueMaximo { get; set; }
}
