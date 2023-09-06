using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGTcePRDB
{
    public partial class TbGerEscopo
    {
        public TbGerEscopo()
        {
            TbGerLeiAtos = new HashSet<TbGerLeiAto>();
            TbGerTipoDocumentoXescopos = new HashSet<TbGerTipoDocumentoXescopo>();
        }

        public short IdEscopo { get; set; }
        public string? DsEscopo { get; set; }
        public string? FlPlurianual { get; set; }

        public virtual ICollection<TbGerLeiAto> TbGerLeiAtos { get; set; }
        public virtual ICollection<TbGerTipoDocumentoXescopo> TbGerTipoDocumentoXescopos { get; set; }
    }
}
