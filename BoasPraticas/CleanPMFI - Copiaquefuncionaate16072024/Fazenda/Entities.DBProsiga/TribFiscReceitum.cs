using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class TribFiscReceitum
{
    public int RecId { get; set; }

    public long IdtipoProcFiscal { get; set; }

    public int? RecNumero { get; set; }

    public long? EmprCmc { get; set; }

    public string? Paciente { get; set; }

    public virtual ICollection<TribFiscReceitaItem> TribFiscReceitaItems { get; set; } = new List<TribFiscReceitaItem>();

    public virtual ICollection<TribFiscProtocolo> Prots { get; set; } = new List<TribFiscProtocolo>();
}
