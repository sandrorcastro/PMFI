﻿using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TemptribZonaZoneamentoAtividade
    {
        public short ZozoId { get; set; }
        public string Atividade { get; set; } = null!;
        public short ZotlId { get; set; }
    }
}
