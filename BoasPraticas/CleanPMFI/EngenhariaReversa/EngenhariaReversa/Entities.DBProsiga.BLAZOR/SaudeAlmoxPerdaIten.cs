﻿using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class SaudeAlmoxPerdaIten
    {
        public long IdPerdaItem { get; set; }
        public long? IdPerda { get; set; }
        public long? IdAlmox { get; set; }
        public string? IdentLote { get; set; }
        public long? IdMedicamento { get; set; }
        public long? IdFabricante { get; set; }
        public long? Qtd { get; set; }
        public long? SaldoLote { get; set; }
        public int? SaldoMedicamento { get; set; }
        public DateTime? DtMovimento { get; set; }
        public string? HrMovimento { get; set; }
        public string? Status { get; set; }

        public virtual SaudeAlmoxPerda? IdPerdaNavigation { get; set; }
    }
}
