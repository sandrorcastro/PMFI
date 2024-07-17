using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbPlaUnidadesMedidasPadrao
{
    public short IdUnidadeMedidaPadrao { get; set; }

    public string? DsUnidadeMedidaPadrao { get; set; }

    public virtual ICollection<TbDspUnidadesMedidum> TbDspUnidadesMedida { get; set; } = new List<TbDspUnidadesMedidum>();

    public virtual ICollection<TbPlaObjetivosMilenioMedidasEsperada> TbPlaObjetivosMilenioMedidasEsperada { get; set; } = new List<TbPlaObjetivosMilenioMedidasEsperada>();

    public virtual ICollection<TbPlaUnidadesMedidum> TbPlaUnidadesMedida { get; set; } = new List<TbPlaUnidadesMedidum>();

    public virtual ICollection<TbPlaProdutosPadrao> IdProdutoPadraos { get; set; } = new List<TbPlaProdutosPadrao>();
}
