using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.NFSEDB
{
    public partial class NfseTblFaq
    {
        public int Idfaq { get; set; }
        public string Sttitulo { get; set; } = null!;
        public string Stsolucao { get; set; } = null!;
        public string? Stform { get; set; }
        public int? Nuordem { get; set; }
        public int Idfaqgrupo { get; set; }
    }
}
