using System;
using System.Collections.Generic;

namespace Domain.Entities.NFSEDB
{
    public partial class NfseTblFaqResposta
    {
        public long Id { get; set; }
        public int Idfaq { get; set; }
        public string Stresposta { get; set; } = null!;
        public int Idcontribuinte { get; set; }
        public DateTime Dtinclusao { get; set; }
    }
}
