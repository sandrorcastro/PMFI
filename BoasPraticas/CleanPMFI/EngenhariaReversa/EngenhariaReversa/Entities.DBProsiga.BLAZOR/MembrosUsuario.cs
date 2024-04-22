using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class MembrosUsuario
    {
        public string UmeidUsu { get; set; } = null!;
        public string Umecgc { get; set; } = null!;
        public string? UmeCnpjPadrao { get; set; }

        public virtual Membro UmecgcNavigation { get; set; } = null!;
        public virtual Usuario UmeidUsuNavigation { get; set; } = null!;
    }
}
