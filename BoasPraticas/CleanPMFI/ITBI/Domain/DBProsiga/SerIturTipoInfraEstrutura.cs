using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class SerIturTipoInfraEstrutura
    {
        public SerIturTipoInfraEstrutura()
        {
            SerIturEmpresaInfraEstruturas = new HashSet<SerIturEmpresaInfraEstrutura>();
            SerIturGrupoServEquipTipoEstabs = new HashSet<SerIturGrupoServEquipTipoEstab>();
        }

        public int TipoInfraEstId { get; set; }
        public string? TipoInfraEstNome { get; set; }

        public virtual ICollection<SerIturEmpresaInfraEstrutura> SerIturEmpresaInfraEstruturas { get; set; }
        public virtual ICollection<SerIturGrupoServEquipTipoEstab> SerIturGrupoServEquipTipoEstabs { get; set; }
    }
}
