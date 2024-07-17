using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class TbDivTipoUnidadeTce
{
    public short IdTipoUnidadeTce { get; set; }

    public string? DsTipoUnidadeTce { get; set; }

    public virtual ICollection<TbDivInscricaoSancao> TbDivInscricaoSancaos { get; set; } = new List<TbDivInscricaoSancao>();
}
