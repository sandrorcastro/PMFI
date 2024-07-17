using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class GccPermisso
    {
        public string Cnpjmembro { get; set; } = null!;
        public string UsuId { get; set; } = null!;
        public int? CrecheId { get; set; }
        public string? AcessoTotal { get; set; }
    }
}
