using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class VisaoEdifeinscricao
{
    public long EdificacaoId { get; set; }

    public long? TerrenoId { get; set; }

    public long? EdifJuntarAoCarne { get; set; }

    public decimal EdifFracaoIdealEdificacao { get; set; }

    public string InscricaoImobiliaria { get; set; } = null!;
}
