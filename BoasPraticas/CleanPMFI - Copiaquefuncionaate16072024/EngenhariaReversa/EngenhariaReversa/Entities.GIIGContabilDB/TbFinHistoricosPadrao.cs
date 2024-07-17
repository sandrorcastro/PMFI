using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbFinHistoricosPadrao
    {
        public TbFinHistoricosPadrao()
        {
            TbFinContasContabeisLancamentosAnalisadors = new HashSet<TbFinContasContabeisLancamentosAnalisador>();
        }

        public int CdHistorico { get; set; }
        public string? DsHistorico { get; set; }
        public int? CdEvento { get; set; }
        public bool? FlDesativado { get; set; }

        public virtual ICollection<TbFinContasContabeisLancamentosAnalisador> TbFinContasContabeisLancamentosAnalisadors { get; set; }
    }
}
