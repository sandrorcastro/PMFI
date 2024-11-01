﻿using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class OuvidoriaOrgao
    {
        public OuvidoriaOrgao()
        {
            OuvidoriaProcessos = new HashSet<OuvidoriaProcesso>();
        }

        public int IdouvOrgao { get; set; }
        public string NmOrgao { get; set; } = null!;

        public virtual ICollection<OuvidoriaProcesso> OuvidoriaProcessos { get; set; }
    }
}
