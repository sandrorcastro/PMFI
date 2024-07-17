using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class Tbwhatsmensagem
    {
        public int Idmensagem { get; set; }
        public long? Chatid { get; set; }
        public string? Dsmensagem { get; set; }
        public int? Idservico { get; set; }
        public string? Flenvio { get; set; }
        public DateTime? Dtinclusao { get; set; }
        public string Dsservico { get; set; } = null!;
    }
}
