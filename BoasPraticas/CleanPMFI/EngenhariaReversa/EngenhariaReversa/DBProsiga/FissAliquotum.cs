﻿using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class FissAliquotum
    {
        public long AliqId { get; set; }
        public string? AliqDescricao { get; set; }
        public decimal? AliqAliquota { get; set; }
    }
}
