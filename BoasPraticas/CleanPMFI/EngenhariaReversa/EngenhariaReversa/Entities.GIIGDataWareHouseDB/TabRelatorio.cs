using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGDataWareHouseDB
{
    public partial class TabRelatorio
    {
        public TabRelatorio()
        {
            TabPermissoesMovs = new HashSet<TabPermissoesMov>();
            TabRelatoriosVersaos = new HashSet<TabRelatoriosVersao>();
        }

        public short IdRelatorio { get; set; }
        public string? NmRelatorio { get; set; }
        public string? DsRelatorio { get; set; }
        public bool? FlAtivo { get; set; }
        public short? IdGrupo { get; set; }
        public DateTime? DtInclusao { get; set; }
        public string? DsLogin { get; set; }

        public virtual TabRelatoriosGrupo? IdGrupoNavigation { get; set; }
        public virtual ICollection<TabPermissoesMov> TabPermissoesMovs { get; set; }
        public virtual ICollection<TabRelatoriosVersao> TabRelatoriosVersaos { get; set; }
    }
}
