using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbRelQuery
    {
        public short IdQuery { get; set; }
        public short? IdEmpresa { get; set; }
        public string? NmQuery { get; set; }
        public string? DsQuery { get; set; }
        public DateTime? DtInclusao { get; set; }
        public string? DsLogin { get; set; }
    }
}
