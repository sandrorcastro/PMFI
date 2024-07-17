using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbWflRecebimento
    {
        public TbWflRecebimento()
        {
            IdRemessas = new HashSet<TbWflRemessa>();
        }

        public int IdRecebimento { get; set; }
        public DateTime? DtRecebimento { get; set; }
        public string? DsLogin { get; set; }

        public virtual ICollection<TbWflRemessa> IdRemessas { get; set; }
    }
}
