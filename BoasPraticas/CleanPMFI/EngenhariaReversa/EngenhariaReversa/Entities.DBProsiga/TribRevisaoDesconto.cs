﻿using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class TribRevisaoDesconto
    {
        public long ImoIddivida { get; set; }
        public int TipoTribId { get; set; }
        public decimal RevPercDesconto { get; set; }
        public string? RevObs { get; set; }
    }
}
