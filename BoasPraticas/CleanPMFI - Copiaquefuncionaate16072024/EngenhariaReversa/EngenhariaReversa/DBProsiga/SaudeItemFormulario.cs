using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class SaudeItemFormulario
    {
        public long CdFormulario { get; set; }
        public int CdMedicamento { get; set; }
        public int? Qtd { get; set; }
        public string? QtdFornecida { get; set; }
    }
}
