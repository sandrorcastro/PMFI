﻿using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class OuvidoriaServico
    {
        public OuvidoriaServico()
        {
            OuvidoriaProcessos = new HashSet<OuvidoriaProcesso>();
        }

        public int IdouvServico { get; set; }
        public string DescrServico { get; set; } = null!;

        public virtual ICollection<OuvidoriaProcesso> OuvidoriaProcessos { get; set; }
    }
}
