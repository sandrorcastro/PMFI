using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbPlaProdutosPadrao
{
    public short IdProdutoPadrao { get; set; }

    public string? DsProdutoPadrao { get; set; }

    public virtual ICollection<TbPlaProduto> TbPlaProdutos { get; set; } = new List<TbPlaProduto>();

    public virtual ICollection<TbPlaUnidadesMedidasPadrao> IdUnidadeMedidaPadraos { get; set; } = new List<TbPlaUnidadesMedidasPadrao>();
}
