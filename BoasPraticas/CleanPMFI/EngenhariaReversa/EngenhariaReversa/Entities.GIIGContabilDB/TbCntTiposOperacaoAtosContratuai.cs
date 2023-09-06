using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbCntTiposOperacaoAtosContratuai
    {
        public TbCntTiposOperacaoAtosContratuai()
        {
            TbCntAtosContratuais = new HashSet<TbCntAtosContratuai>();
            IdTipoAtoContratuals = new HashSet<TbCntTiposAtosContratuai>();
        }

        public short IdTipoOperacaoAto { get; set; }
        public string? DsTipoOperacao { get; set; }
        public short? CdTc { get; set; }

        public virtual ICollection<TbCntAtosContratuai> TbCntAtosContratuais { get; set; }

        public virtual ICollection<TbCntTiposAtosContratuai> IdTipoAtoContratuals { get; set; }
    }
}
