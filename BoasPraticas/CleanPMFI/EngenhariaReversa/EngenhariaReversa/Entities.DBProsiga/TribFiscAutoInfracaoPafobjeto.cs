﻿using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class TribFiscAutoInfracaoPafobjeto
    {
        public int Pafid { get; set; }
        public int ObjetoId { get; set; }

        public virtual TribFiscAutoInfracaoPaf Paf { get; set; } = null!;
    }
}
