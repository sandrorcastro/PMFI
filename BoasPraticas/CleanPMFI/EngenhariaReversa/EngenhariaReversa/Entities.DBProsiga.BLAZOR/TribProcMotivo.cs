﻿using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class TribProcMotivo
    {
        public TribProcMotivo()
        {
            TribProcSuspensaoMotivos = new HashSet<TribProcSuspensaoMotivo>();
        }

        public int ProcMotId { get; set; }
        public string? ProcMotNome { get; set; }

        public virtual ICollection<TribProcSuspensaoMotivo> TribProcSuspensaoMotivos { get; set; }
    }
}
