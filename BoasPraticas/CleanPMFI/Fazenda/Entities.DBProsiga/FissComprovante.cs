using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class FissComprovante
{
    public long CompId { get; set; }

    public DateTime? CompData { get; set; }

    public long? EmprCmc { get; set; }

    public long? ConId { get; set; }

    public long? ContadorId { get; set; }

    public string? CompSituacao { get; set; }

    public string? CompSituacaoCanc { get; set; }

    public virtual ICollection<FissCompDividum> FissCompDivida { get; set; } = new List<FissCompDividum>();

    public virtual ICollection<FissComprovanteIten> FissComprovanteItens { get; set; } = new List<FissComprovanteIten>();
}
