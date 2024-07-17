using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.NFSEDB
{
    public partial class NfseTblFaqResplike
    {
        public long Idresposta { get; set; }
        public int Idcontribuinte { get; set; }
        public string Flajudou { get; set; } = null!;
    }
}
