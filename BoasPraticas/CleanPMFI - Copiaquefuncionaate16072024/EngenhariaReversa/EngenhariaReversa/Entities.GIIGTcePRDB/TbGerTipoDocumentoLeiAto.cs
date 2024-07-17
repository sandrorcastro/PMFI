using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGTcePRDB
{
    public partial class TbGerTipoDocumentoLeiAto
    {
        public TbGerTipoDocumentoLeiAto()
        {
            TbGerLeiAtos = new HashSet<TbGerLeiAto>();
            TbGerTipoDocumentoXescopos = new HashSet<TbGerTipoDocumentoXescopo>();
        }

        public short IdTipoDocumento { get; set; }
        public string? DsTipoDocumento { get; set; }
        public string? FlExigeNumeroDocumento { get; set; }

        public virtual ICollection<TbGerLeiAto> TbGerLeiAtos { get; set; }
        public virtual ICollection<TbGerTipoDocumentoXescopo> TbGerTipoDocumentoXescopos { get; set; }
    }
}
