﻿using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class TribEmpresasFatorAreaAbertum
    {
        public short FatAbertaId { get; set; }
        public int? TipoTribId { get; set; }
        public decimal? FatAbertaAreaDe { get; set; }
        public decimal? FatAbertaAreaAte { get; set; }
        public decimal? FatAbertaFator { get; set; }
    }
}
