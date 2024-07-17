using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbCntAtosContratuaisPublicaco
    {
        public int IdNumeroAto { get; set; }
        public int IdOrgaoOficial { get; set; }
        public DateTime? DtPublicacao { get; set; }

        public virtual TbCntNumeroAtosContratuai IdNumeroAtoNavigation { get; set; } = null!;
        public virtual TbGerOrgaoOficialPublicacao IdOrgaoOficialNavigation { get; set; } = null!;
    }
}
