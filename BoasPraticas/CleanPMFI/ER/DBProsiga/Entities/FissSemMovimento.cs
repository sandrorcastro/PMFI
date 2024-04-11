using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class FissSemMovimento
{
    public long SemMovId { get; set; }

    public DateTime? SemMovData { get; set; }

    public int? SemMovAnoComp { get; set; }

    public int? SemMovMesComp { get; set; }

    public long? EmprCmc { get; set; }

    public long? ContadorId { get; set; }

    public string? SemMovSituacao { get; set; }

    /// <summary>
    /// Indica que o movimento foi totalmente retido na fonte ai eh outro tipo de baixa
    /// </summary>
    public string? SemMovMovTotalRetido { get; set; }

    public virtual ICollection<FissComprovanteIten> FissComprovanteItens { get; set; } = new List<FissComprovanteIten>();
}
