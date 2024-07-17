using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class TribEdifAtributosDinamico
{
    public long EdificacaoId { get; set; }

    public int TabParId { get; set; }

    public string? Valor { get; set; }

    public virtual TribEdificaco Edificacao { get; set; } = null!;

    public virtual TabAtributosDinamico TabPar { get; set; } = null!;
}
