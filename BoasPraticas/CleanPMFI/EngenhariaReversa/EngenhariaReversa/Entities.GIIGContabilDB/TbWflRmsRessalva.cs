using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbWflRmsRessalva
    {
        public int IdRessalva { get; set; }
        public int? IdRms { get; set; }
        public string? DsLogin { get; set; }
        public DateTime? DtRessalva { get; set; }
        public string? DsRessalva { get; set; }
        public string? DsLoginResposta { get; set; }
        public DateTime? DtResposta { get; set; }
        public string? DsResposta { get; set; }
    }
}
