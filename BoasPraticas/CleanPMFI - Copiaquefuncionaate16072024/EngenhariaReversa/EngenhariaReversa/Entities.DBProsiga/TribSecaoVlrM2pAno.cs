﻿using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class TribSecaoVlrM2pAno
    {
        public int VlrM2pAnoId { get; set; }
        public int SecaoId { get; set; }
        public string? Secao { get; set; }
        public decimal? VlrMetroQuadrado { get; set; }
        public int? Ano { get; set; }

        public virtual TribSecao SecaoNavigation { get; set; } = null!;
    }
}
