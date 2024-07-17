using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGConsultaPreviaDB
{
    public partial class TabCnaeunidade
    {
        public int IdFluxo { get; set; }
        public string SubCid { get; set; } = null!;
        public int UnidId { get; set; }
        public int? IdDesdobramento { get; set; }
    }
}
