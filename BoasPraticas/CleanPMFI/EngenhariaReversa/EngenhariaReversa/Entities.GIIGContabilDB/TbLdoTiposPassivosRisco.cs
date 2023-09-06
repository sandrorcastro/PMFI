using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbLdoTiposPassivosRisco
    {
        public TbLdoTiposPassivosRisco()
        {
            TbLdoDemRiscosFiscais = new HashSet<TbLdoDemRiscosFiscai>();
        }

        public short IdRisco { get; set; }
        public string? DsRisco { get; set; }

        public virtual ICollection<TbLdoDemRiscosFiscai> TbLdoDemRiscosFiscais { get; set; }
    }
}
