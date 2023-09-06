using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbGerTiposContaBancarium
    {
        public TbGerTiposContaBancarium()
        {
            TbGerContasCorrentes = new HashSet<TbGerContasCorrente>();
        }

        public short IdTipoContaBancaria { get; set; }
        public string? DsTipoContaBancaria { get; set; }

        public virtual ICollection<TbGerContasCorrente> TbGerContasCorrentes { get; set; }
    }
}
