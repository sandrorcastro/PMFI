﻿using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class Uffi
    {
        public DateTime Uffidata { get; set; }
        public decimal? Uffivalor { get; set; }
        public string? UffitecUltAlt { get; set; }
        public DateTime? UffidtUltAlt { get; set; }
    }
}
