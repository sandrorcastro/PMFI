using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbLicTiposDocumento
    {
        public TbLicTiposDocumento()
        {
            TbLicModelosDoctos = new HashSet<TbLicModelosDocto>();
            IdQueries = new HashSet<TbSisQuery>();
        }

        public short IdTipoDocumento { get; set; }
        public string? NmTipoDocumento { get; set; }

        public virtual ICollection<TbLicModelosDocto> TbLicModelosDoctos { get; set; }

        public virtual ICollection<TbSisQuery> IdQueries { get; set; }
    }
}
