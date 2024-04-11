using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class SaudeFarmaRequisicaoItem
{
    public long IdItemRequisicao { get; set; }

    public long? IdRequisicao { get; set; }

    public long? IdMedicamento { get; set; }

    public decimal? Quantidade { get; set; }

    public virtual SaudeFarmaRequisicaoMedic? IdRequisicaoNavigation { get; set; }
}
