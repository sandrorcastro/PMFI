using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbPlaProdutosPadrao
    {
        public TbPlaProdutosPadrao()
        {
            TbPlaProdutos = new HashSet<TbPlaProduto>();
            IdUnidadeMedidaPadraos = new HashSet<TbPlaUnidadesMedidasPadrao>();
        }

        public short IdProdutoPadrao { get; set; }
        public string? DsProdutoPadrao { get; set; }

        public virtual ICollection<TbPlaProduto> TbPlaProdutos { get; set; }

        public virtual ICollection<TbPlaUnidadesMedidasPadrao> IdUnidadeMedidaPadraos { get; set; }
    }
}
