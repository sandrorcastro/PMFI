using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class VisaoFeriado
    {
        public int Código { get; set; }
        public DateTime Data { get; set; }
        public string Tipo { get; set; } = null!;
        public string Descrição { get; set; } = null!;
        public string Status { get; set; } = null!;
    }
}
