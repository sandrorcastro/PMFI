using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbSbsCategoriasDespesa
    {
        public TbSbsCategoriasDespesa()
        {
            TbSbsPlanoAplicacoesAditivos = new HashSet<TbSbsPlanoAplicacoesAditivo>();
            TbSbsPrestacaoConta = new HashSet<TbSbsPrestacaoConta>();
            CdTipoDespesas = new HashSet<TbSbsTipoDespesa>();
        }

        public int IdCatDespesa { get; set; }
        public string? NmCatDespesa { get; set; }

        public virtual ICollection<TbSbsPlanoAplicacoesAditivo> TbSbsPlanoAplicacoesAditivos { get; set; }
        public virtual ICollection<TbSbsPrestacaoConta> TbSbsPrestacaoConta { get; set; }

        public virtual ICollection<TbSbsTipoDespesa> CdTipoDespesas { get; set; }
    }
}
