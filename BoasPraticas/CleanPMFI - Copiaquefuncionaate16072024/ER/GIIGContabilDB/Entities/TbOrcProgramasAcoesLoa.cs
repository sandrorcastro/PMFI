using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbOrcProgramasAcoesLoa
{
    public int IdAcaoLoa { get; set; }

    public int IdAcao { get; set; }

    public int IdNatDespesa { get; set; }

    public int? IdFonte { get; set; }

    public int? IdRecurso { get; set; }

    public decimal? VlLimite { get; set; }

    public decimal? VlExpansao { get; set; }

    public string? DsSituacao { get; set; }

    public string? DsParecer { get; set; }

    public string? DsTipo { get; set; }

    public string? DsTipoFisca { get; set; }

    public string? DsTipoOrcamento { get; set; }

    public decimal? VlEmenda { get; set; }

    public string? DsTipoEmenda { get; set; }

    public virtual ICollection<TbOrcProgramasAcoesLoaSubAcoesTarefa> TbOrcProgramasAcoesLoaSubAcoesTarefas { get; set; } = new List<TbOrcProgramasAcoesLoaSubAcoesTarefa>();
}
