﻿using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class TempSerIturEmpresasSemCmcativ
    {
        public long EmprId { get; set; }
        public string Atividade { get; set; } = null!;
        public string? EmprAtivPrincipal { get; set; }
        public DateTime? EmprAtivDataIni { get; set; }
        public DateTime? EmprAtivDataFim { get; set; }
    }
}
