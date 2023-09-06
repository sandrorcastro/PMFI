using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class FormularioInstrucoesTce
    {
        public string FrmId { get; set; } = null!;
        public string? DsTextoExplicativo { get; set; }
        public string? DsLink { get; set; }
    }
}
