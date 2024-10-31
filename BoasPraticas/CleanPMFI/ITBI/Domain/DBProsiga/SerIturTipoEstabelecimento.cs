using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class SerIturTipoEstabelecimento
    {
        public SerIturTipoEstabelecimento()
        {
            SerIturEmpresaInfraEstruturas = new HashSet<SerIturEmpresaInfraEstrutura>();
            SerIturGrupoServEquipTipoEstabs = new HashSet<SerIturGrupoServEquipTipoEstab>();
            AtivGrupos = new HashSet<TribAtivGrupo>();
        }

        public int TipoEstabId { get; set; }
        public string? TipoEstabNome { get; set; }
        public short? GrTiId { get; set; }

        public virtual SeriTurGrupoTipoEstabelecimento? GrTi { get; set; }
        public virtual ICollection<SerIturEmpresaInfraEstrutura> SerIturEmpresaInfraEstruturas { get; set; }
        public virtual ICollection<SerIturGrupoServEquipTipoEstab> SerIturGrupoServEquipTipoEstabs { get; set; }

        public virtual ICollection<TribAtivGrupo> AtivGrupos { get; set; }
    }
}
