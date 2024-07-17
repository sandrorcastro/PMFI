using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class TribSaneparMatric
    {
        public string SaneMatricula { get; set; } = null!;
        public string? SaneEndereco { get; set; }
        public string? SaneNumero { get; set; }
        public short? SaneResidencial { get; set; }
        public short? SaneComercial { get; set; }
        public string? SaneRoteiro { get; set; }
        public short? SaneQtdeMatricula { get; set; }
        public string? SaneObservacao { get; set; }
    }
}
