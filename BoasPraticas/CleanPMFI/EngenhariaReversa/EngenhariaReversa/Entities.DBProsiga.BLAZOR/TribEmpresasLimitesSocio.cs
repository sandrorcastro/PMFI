﻿using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class TribEmpresasLimitesSocio
    {
        public short LimSid { get; set; }
        public string? NivelProfissional { get; set; }
        public short? LimSde { get; set; }
        public short? LimSate { get; set; }
        public decimal? LimScoeficiente { get; set; }
    }
}
