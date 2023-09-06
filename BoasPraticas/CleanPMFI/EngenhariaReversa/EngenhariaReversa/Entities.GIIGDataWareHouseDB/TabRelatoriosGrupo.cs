using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGDataWareHouseDB
{
    public partial class TabRelatoriosGrupo
    {
        public TabRelatoriosGrupo()
        {
            TabRelatorios = new HashSet<TabRelatorio>();
        }

        public short IdGrupo { get; set; }
        public string? DsGrupo { get; set; }

        public virtual ICollection<TabRelatorio> TabRelatorios { get; set; }
    }
}
