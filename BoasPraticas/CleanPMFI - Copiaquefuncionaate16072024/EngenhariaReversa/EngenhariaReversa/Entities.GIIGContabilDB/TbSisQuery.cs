using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbSisQuery
    {
        public TbSisQuery()
        {
            IdTipoDocumentos = new HashSet<TbLicTiposDocumento>();
        }

        public int IdQuery { get; set; }
        public string? NmQuery { get; set; }
        public string? DsQuery { get; set; }
        public string? DsTipoQuery { get; set; }
        public string? DsAgrapumento { get; set; }

        public virtual ICollection<TbLicTiposDocumento> IdTipoDocumentos { get; set; }
    }
}
