using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class SaudeFarmaRequisicaoMedic
{
    public long IdRequisicao { get; set; }

    public DateTime? Data { get; set; }

    public long? IdEstoque { get; set; }

    public long? IdAlmox { get; set; }

    public string? Usuario { get; set; }

    public virtual ICollection<SaudeFarmaRequisicaoItem> SaudeFarmaRequisicaoItems { get; set; } = new List<SaudeFarmaRequisicaoItem>();
}
