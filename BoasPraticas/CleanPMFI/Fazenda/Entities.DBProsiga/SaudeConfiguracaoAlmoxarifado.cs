using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class SaudeConfiguracaoAlmoxarifado
{
    public int CdAlmoxarifado { get; set; }

    public int CdMedicamento { get; set; }

    public int? QtdEstoqueMinimo { get; set; }

    public int? QtdEstoqueMaximo { get; set; }
}
