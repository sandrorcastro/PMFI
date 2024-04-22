using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class Tbautodeclaracao
    {
        public int Idautodeclaracao { get; set; }
        public string Nmtituloautodeclaracao { get; set; } = null!;
        public string Dsautodeclaracao { get; set; } = null!;
        public bool Flativo { get; set; }
    }
}
