using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbOrcTiposOperacaoCreditoAdicional
    {
        public TbOrcTiposOperacaoCreditoAdicional()
        {
            TbOrcAlteracoesOrcamentaria = new HashSet<TbOrcAlteracoesOrcamentaria>();
        }

        public short IdTipoOperacaoCreditoAdicional { get; set; }
        public string? DsTipoOperacaoCreditoAdicional { get; set; }

        public virtual ICollection<TbOrcAlteracoesOrcamentaria> TbOrcAlteracoesOrcamentaria { get; set; }
    }
}
