﻿using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class TempCadBem
    {
        public long Codigo { get; set; }
        public string? Descricaobem { get; set; }
        public int? CodSetor { get; set; }
        public string? Imagem { get; set; }

        public virtual TempSetorBem? CodSetorNavigation { get; set; }
    }
}
