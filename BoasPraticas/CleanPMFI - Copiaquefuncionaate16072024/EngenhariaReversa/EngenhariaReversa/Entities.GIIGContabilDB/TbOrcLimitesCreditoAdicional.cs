using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbOrcLimitesCreditoAdicional
    {
        public TbOrcLimitesCreditoAdicional()
        {
            TbOrcAlteracoesOrcamentaria = new HashSet<TbOrcAlteracoesOrcamentaria>();
        }

        public int IdLimiteCredito { get; set; }
        public int? IdArtigo { get; set; }
        public short? CdControle { get; set; }
        public int? IdTipoExclusao { get; set; }
        public string? FlConsideraLimite { get; set; }
        public string? DsDadosAdicionais { get; set; }
        public short? IdTipoCreditoAdicional { get; set; }

        public virtual TbOrcArtigosCreditoAdicional? IdArtigoNavigation { get; set; }
        public virtual TbOrcTipoCreditoAdicional? IdTipoCreditoAdicionalNavigation { get; set; }
        public virtual TbOrcTiposExclusaoCreditoAdicional? IdTipoExclusaoNavigation { get; set; }
        public virtual ICollection<TbOrcAlteracoesOrcamentaria> TbOrcAlteracoesOrcamentaria { get; set; }
    }
}
