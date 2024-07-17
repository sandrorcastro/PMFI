using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbDspCodigosPagamentoInss
    {
        public TbDspCodigosPagamentoInss()
        {
            TbDspGps = new HashSet<TbDspGp>();
        }

        public short CdPagamento { get; set; }
        public string? DsPagamento { get; set; }

        public virtual ICollection<TbDspGp> TbDspGps { get; set; }
    }
}
