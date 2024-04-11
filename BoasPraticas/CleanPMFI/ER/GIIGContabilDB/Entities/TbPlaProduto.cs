using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbPlaProduto
{
    public short IdProduto { get; set; }

    public string? DsProduto { get; set; }

    public short IdProdutoPadrao { get; set; }

    public short? NrAnoLimite { get; set; }

    public virtual TbPlaProdutosPadrao IdProdutoPadraoNavigation { get; set; } = null!;
}
