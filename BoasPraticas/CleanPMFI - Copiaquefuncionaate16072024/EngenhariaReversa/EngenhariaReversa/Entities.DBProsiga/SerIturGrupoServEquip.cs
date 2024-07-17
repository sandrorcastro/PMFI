using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class SerIturGrupoServEquip
    {
        public SerIturGrupoServEquip()
        {
            SerIturGrupoServEquipTipoEstabs = new HashSet<SerIturGrupoServEquipTipoEstab>();
            SerIturServEquipGrupos = new HashSet<SerIturServEquipGrupo>();
        }

        public int GrupoServEquipId { get; set; }
        public string? GrupoServEquipNome { get; set; }
        public string? GrupoServDispEmpresas { get; set; }
        public string? GrupoServDispAtrativos { get; set; }
        public int? GrupoServOrdem { get; set; }
        public string? GrupoServExterno { get; set; }

        public virtual ICollection<SerIturGrupoServEquipTipoEstab> SerIturGrupoServEquipTipoEstabs { get; set; }
        public virtual ICollection<SerIturServEquipGrupo> SerIturServEquipGrupos { get; set; }
    }
}
