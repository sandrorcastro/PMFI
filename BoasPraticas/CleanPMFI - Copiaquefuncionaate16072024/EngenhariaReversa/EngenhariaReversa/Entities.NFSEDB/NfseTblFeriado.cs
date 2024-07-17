using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.NFSEDB
{
    public partial class NfseTblFeriado
    {
        public int Idferiado { get; set; }
        public int Nudia { get; set; }
        public int Numes { get; set; }
        public string Stnome { get; set; } = null!;
        public DateTime? Data { get; set; }
    }
}
