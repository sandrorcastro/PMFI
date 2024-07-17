using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class TipoBaixa
{
    public int TipoBaixaId { get; set; }

    public string TipoBaixaNome { get; set; } = null!;

    public int? TbcodTribunal { get; set; }

    public virtual ICollection<AtoBaixa> AtoBaixas { get; set; } = new List<AtoBaixa>();
}
