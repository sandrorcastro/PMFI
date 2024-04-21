using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TribTempDam
    {
        public string TDamsessionId { get; set; } = null!;
        public string TDamdivida { get; set; } = null!;
        public string? TCadastro { get; set; }
    }
}
