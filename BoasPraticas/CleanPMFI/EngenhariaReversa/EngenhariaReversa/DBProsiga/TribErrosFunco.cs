﻿using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TribErrosFunco
    {
        public decimal? TribErro { get; set; }
        public string? TribMotivoErro { get; set; }
        public string? TribDescricao { get; set; }
    }
}
