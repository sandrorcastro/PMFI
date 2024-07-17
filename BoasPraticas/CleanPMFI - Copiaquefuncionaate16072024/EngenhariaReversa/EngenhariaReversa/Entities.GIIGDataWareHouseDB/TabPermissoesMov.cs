using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGDataWareHouseDB
{
    public partial class TabPermissoesMov
    {
        public int IdPermissoesMov { get; set; }
        public short? IdRelatorio { get; set; }
        public string? DsLogin { get; set; }
        public string? DsTipoMov { get; set; }
        public DateTime? DtInclusao { get; set; }
        public string? DsLoginInclusao { get; set; }

        public virtual TabRelatorio? IdRelatorioNavigation { get; set; }
    }
}
