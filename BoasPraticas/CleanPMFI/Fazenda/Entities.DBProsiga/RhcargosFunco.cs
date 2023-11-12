using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class RhcargosFunco
{
    public long CargoFuncId { get; set; }

    public string? CargoFuncNome { get; set; }

    public virtual ICollection<EdumovimentoLotacao> EdumovimentoLotacaos { get; set; } = new List<EdumovimentoLotacao>();

    public virtual ICollection<RhcargoFuncaoLocal> RhcargoFuncaoLocals { get; set; } = new List<RhcargoFuncaoLocal>();

    public virtual ICollection<RhdadosFuncionai> RhdadosFuncionaiCargoFuncIdatualNavigations { get; set; } = new List<RhdadosFuncionai>();

    public virtual ICollection<RhdadosFuncionai> RhdadosFuncionaiCargoFuncs { get; set; } = new List<RhdadosFuncionai>();
}
