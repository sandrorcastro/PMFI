﻿using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class VwConsultapreviaListagraurisco
    {
        public string Atividade { get; set; } = null!;
        public short SetorId { get; set; }
        public string? SetorNome { get; set; }
        public string? Risco { get; set; }
    }
}
