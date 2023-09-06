using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbFinTiposConciliacao
    {
        public TbFinTiposConciliacao()
        {
            TbFinConciliacoesBancaria = new HashSet<TbFinConciliacoesBancaria>();
        }

        public int IdTipoConciliacao { get; set; }
        public string? DsTipoConciliacao { get; set; }
        public string? DsExtratoLancamento { get; set; }
        public string? DsTipoOperacao { get; set; }
        public short? CdTc { get; set; }
        public bool? FlAtivo { get; set; }
        public int? IdTipoContraPartida { get; set; }
        public bool? FlManual { get; set; }

        public virtual ICollection<TbFinConciliacoesBancaria> TbFinConciliacoesBancaria { get; set; }
    }
}
