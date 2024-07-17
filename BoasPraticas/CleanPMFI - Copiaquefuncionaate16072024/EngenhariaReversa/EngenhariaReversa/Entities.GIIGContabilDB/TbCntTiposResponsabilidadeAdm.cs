using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbCntTiposResponsabilidadeAdm
    {
        public TbCntTiposResponsabilidadeAdm()
        {
            TbCntResponsabilidadesAdministrativas = new HashSet<TbCntResponsabilidadesAdministrativa>();
        }

        public short IdTipoRespAdm { get; set; }
        public string? DsTipoRespAdm { get; set; }
        public string? DsSigla { get; set; }

        public virtual ICollection<TbCntResponsabilidadesAdministrativa> TbCntResponsabilidadesAdministrativas { get; set; }
    }
}
