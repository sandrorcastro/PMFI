using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGDataWareHouseDB
{
    public partial class TabRelatoriosVersao
    {
        public int IdVersao { get; set; }
        public short? IdRelatorio { get; set; }
        public string? DsEndereco { get; set; }
        public DateTime? DtInclusao { get; set; }
        public string? DsSenha { get; set; }
        public string? DsLogin { get; set; }

        public virtual TabRelatorio? IdRelatorioNavigation { get; set; }
    }
}
