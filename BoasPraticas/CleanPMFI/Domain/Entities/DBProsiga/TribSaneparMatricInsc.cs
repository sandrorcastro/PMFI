﻿using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TribSaneparMatricInsc
    {
        public string SaneMatricula { get; set; } = null!;
        public long EdificacaoId { get; set; }
        public string? SainObservacao { get; set; }
    }
}
