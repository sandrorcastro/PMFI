﻿using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.NFSEDB
{
    public partial class NfseTblFaqGrupo
    {
        public int Idfaqgrupo { get; set; }
        public string Stnome { get; set; } = null!;
        public int? Nuordem { get; set; }
    }
}
