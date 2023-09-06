using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbSbsTipoBeneficiario
    {
        public TbSbsTipoBeneficiario()
        {
            TbSbsPrestacaoConta = new HashSet<TbSbsPrestacaoConta>();
        }

        public int IdTipoBeneficiario { get; set; }
        public string? NmTipoBeneficiario { get; set; }

        public virtual ICollection<TbSbsPrestacaoConta> TbSbsPrestacaoConta { get; set; }
    }
}
