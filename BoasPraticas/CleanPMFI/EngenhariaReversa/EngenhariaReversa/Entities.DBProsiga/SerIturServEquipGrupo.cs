using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class SerIturServEquipGrupo
    {
        public SerIturServEquipGrupo()
        {
            SerIturAtrativosServicosEquipamentos = new HashSet<SerIturAtrativosServicosEquipamento>();
            SerIturEmpresaServicosEquipamentos = new HashSet<SerIturEmpresaServicosEquipamento>();
        }

        public int GrupoServEquipId { get; set; }
        public int ServEquipId { get; set; }
        public int? OrdemServEquip { get; set; }

        public virtual SerIturGrupoServEquip GrupoServEquip { get; set; } = null!;
        public virtual SerIturServicosEquipamento ServEquip { get; set; } = null!;
        public virtual ICollection<SerIturAtrativosServicosEquipamento> SerIturAtrativosServicosEquipamentos { get; set; }
        public virtual ICollection<SerIturEmpresaServicosEquipamento> SerIturEmpresaServicosEquipamentos { get; set; }
    }
}
