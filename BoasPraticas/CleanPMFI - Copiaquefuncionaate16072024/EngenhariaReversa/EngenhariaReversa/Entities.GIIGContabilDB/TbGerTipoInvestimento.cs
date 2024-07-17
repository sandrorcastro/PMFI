using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbGerTipoInvestimento
    {
        public TbGerTipoInvestimento()
        {
            TbCapRecursosContasCorrentes = new HashSet<TbCapRecursosContasCorrente>();
        }

        public short IdTipoInvestimento { get; set; }
        public string? DsTipoInvstimento { get; set; }
        public string? FlPrevidencia { get; set; }

        public virtual ICollection<TbCapRecursosContasCorrente> TbCapRecursosContasCorrentes { get; set; }
    }
}
