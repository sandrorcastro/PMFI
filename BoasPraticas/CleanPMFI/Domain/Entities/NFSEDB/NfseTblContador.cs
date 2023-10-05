using System;
using System.Collections.Generic;

namespace Domain.Entities.NFSEDB
{
    public partial class NfseTblContador
    {
        public string Stcrc { get; set; } = null!;
        public int? Idcontribuinte { get; set; }
        public string? Stsituacao { get; set; }
    }
}
