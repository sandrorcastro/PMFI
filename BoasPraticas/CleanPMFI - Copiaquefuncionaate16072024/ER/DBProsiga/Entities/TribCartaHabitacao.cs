using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribCartaHabitacao
{
    public long Idcarta { get; set; }

    public DateTime? DataEmissao { get; set; }

    public long? IdparamAssinatura { get; set; }

    public string? Status { get; set; }

    public virtual ICollection<TribCartaHabitacaoAlvaraConstr> TribCartaHabitacaoAlvaraConstrs { get; set; } = new List<TribCartaHabitacaoAlvaraConstr>();

    public virtual ICollection<Processo> Procs { get; set; } = new List<Processo>();
}
