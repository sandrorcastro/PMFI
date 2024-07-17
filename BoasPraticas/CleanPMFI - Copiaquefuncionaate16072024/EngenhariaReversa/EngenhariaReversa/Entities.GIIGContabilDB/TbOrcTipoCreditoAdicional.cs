using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbOrcTipoCreditoAdicional
    {
        public TbOrcTipoCreditoAdicional()
        {
            TbOrcAlteracoesOrcamentaria = new HashSet<TbOrcAlteracoesOrcamentaria>();
            TbOrcAutorizacaoCreditoAdicionals = new HashSet<TbOrcAutorizacaoCreditoAdicional>();
            TbOrcLimitesCreditoAdicionals = new HashSet<TbOrcLimitesCreditoAdicional>();
        }

        public short IdTipoCreditoAdicional { get; set; }
        public string? DsTipoCreditoAdicional { get; set; }

        public virtual ICollection<TbOrcAlteracoesOrcamentaria> TbOrcAlteracoesOrcamentaria { get; set; }
        public virtual ICollection<TbOrcAutorizacaoCreditoAdicional> TbOrcAutorizacaoCreditoAdicionals { get; set; }
        public virtual ICollection<TbOrcLimitesCreditoAdicional> TbOrcLimitesCreditoAdicionals { get; set; }
    }
}
