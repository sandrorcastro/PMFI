﻿using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class TribAlvaraConstrucaoEdificaco
    {
        public long Numero { get; set; }
        public long EdificacaoId { get; set; }
        public DateTime? DataCad { get; set; }
    }
}
