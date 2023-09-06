using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbCntTiposAtosContratuai
    {
        public TbCntTiposAtosContratuai()
        {
            TbCntAtosContratuais = new HashSet<TbCntAtosContratuai>();
            IdTipoOperacaoAtos = new HashSet<TbCntTiposOperacaoAtosContratuai>();
        }

        public short IdTipoAtoContratual { get; set; }
        public string? NmTipoAtoContratual { get; set; }
        public string? DsSigla { get; set; }
        public short? CdTc { get; set; }
        public bool? FlAtivo { get; set; }
        public bool? FlAtivoApostilamento { get; set; }

        public virtual ICollection<TbCntAtosContratuai> TbCntAtosContratuais { get; set; }

        public virtual ICollection<TbCntTiposOperacaoAtosContratuai> IdTipoOperacaoAtos { get; set; }
    }
}
