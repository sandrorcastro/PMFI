﻿using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbDspRetOcorrenciasGp
    {
        public int IdOcorrencia { get; set; }
        public string CdOcorrencia { get; set; } = null!;
        public string? DsOcorrencia { get; set; }
        public string? DsTipo { get; set; }
    }
}
