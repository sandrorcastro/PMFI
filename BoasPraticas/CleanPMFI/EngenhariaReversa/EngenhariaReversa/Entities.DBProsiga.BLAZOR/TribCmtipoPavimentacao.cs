﻿using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class TribCmtipoPavimentacao
    {
        public TribCmtipoPavimentacao()
        {
            TribCmprocessos = new HashSet<TribCmprocesso>();
        }

        public int CmtipoPavId { get; set; }
        public string? CmtipoPavNome { get; set; }

        public virtual ICollection<TribCmprocesso> TribCmprocessos { get; set; }
    }
}
