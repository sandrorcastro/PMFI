using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class GccCriCreche
{
    public string Cnpjmembro { get; set; } = null!;

    public int CrecheId { get; set; }

    public long CriId { get; set; }

    public int? FaseId { get; set; }

    public DateTime? DtCadastro { get; set; }

    public DateTime? DtMatricula { get; set; }

    public DateTime? DtTransferencia { get; set; }

    public DateTime? DtDesligamento { get; set; }

    public string? Situacao { get; set; }

    public virtual GccCrianca C { get; set; } = null!;

    public virtual GccCreFase? GccCreFase { get; set; }

    public virtual ICollection<GccFalta> GccFalta { get; set; } = new List<GccFalta>();

    public virtual ICollection<GccMovtoOcor> GccMovtoOcors { get; set; } = new List<GccMovtoOcor>();
}
