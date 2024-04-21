﻿using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TribProcRecursosOrigem
    {
        public TribProcRecursosOrigem()
        {
            TribProcRecursosOrigemDets = new HashSet<TribProcRecursosOrigemDet>();
        }

        public int ProcRecOrigemId { get; set; }
        public string? ProcRecOrigemNome { get; set; }

        public virtual ICollection<TribProcRecursosOrigemDet> TribProcRecursosOrigemDets { get; set; }
    }
}
