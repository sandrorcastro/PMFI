using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class TribAtivSetor
{
    public int AtSetId { get; set; }

    public string AtSetDescricao { get; set; } = null!;

    public virtual ICollection<TribAtivAtividade> TribAtivAtividades { get; set; } = new List<TribAtivAtividade>();

    public virtual ICollection<TribAtivSetorTributo> TribAtivSetorTributos { get; set; } = new List<TribAtivSetorTributo>();
}
