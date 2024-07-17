using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class TipoConcessao
{
    public int IdTipoConcessao { get; set; }

    public string TipoConcessao1 { get; set; } = null!;

    public virtual ICollection<ContratoConcessao> ContratoConcessaos { get; set; } = new List<ContratoConcessao>();
}
