using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbFinClassesOperacoesCredito
    {
        public TbFinClassesOperacoesCredito()
        {
            TbFinDividaFundada = new HashSet<TbFinDividaFundadum>();
        }

        public int IdClasseOperacaoCredito { get; set; }
        public string? CdClassificacao { get; set; }
        public string? DsClasse { get; set; }
        public string? DsTipo { get; set; }
        public bool? FlAtivo { get; set; }

        public virtual ICollection<TbFinDividaFundadum> TbFinDividaFundada { get; set; }
    }
}
