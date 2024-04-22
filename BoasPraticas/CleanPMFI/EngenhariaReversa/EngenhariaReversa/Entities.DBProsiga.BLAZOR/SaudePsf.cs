﻿using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class SaudePsf
    {
        public int Idpsf { get; set; }
        public string? NomePsf { get; set; }
        public int? IdUnidadeSaude { get; set; }

        public virtual UnidadeSaude? IdUnidadeSaudeNavigation { get; set; }
    }
}
