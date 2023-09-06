using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbPlaUnidadesMedidasPadrao
    {
        public TbPlaUnidadesMedidasPadrao()
        {
            TbDspUnidadesMedida = new HashSet<TbDspUnidadesMedidum>();
            TbPlaObjetivosMilenioMedidasEsperada = new HashSet<TbPlaObjetivosMilenioMedidasEsperada>();
            TbPlaUnidadesMedida = new HashSet<TbPlaUnidadesMedidum>();
            IdProdutoPadraos = new HashSet<TbPlaProdutosPadrao>();
        }

        public short IdUnidadeMedidaPadrao { get; set; }
        public string? DsUnidadeMedidaPadrao { get; set; }

        public virtual ICollection<TbDspUnidadesMedidum> TbDspUnidadesMedida { get; set; }
        public virtual ICollection<TbPlaObjetivosMilenioMedidasEsperada> TbPlaObjetivosMilenioMedidasEsperada { get; set; }
        public virtual ICollection<TbPlaUnidadesMedidum> TbPlaUnidadesMedida { get; set; }

        public virtual ICollection<TbPlaProdutosPadrao> IdProdutoPadraos { get; set; }
    }
}
