﻿using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class AguaCqparam
    {
        public int CqparamId { get; set; }
        public string? CqparamNome { get; set; }
        public string? CqparamVmp { get; set; }
        public string? CqparamUnidade { get; set; }
    }
}
