using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class MaquinasUsuario
    {
        public int IdUsu { get; set; }
        public string Ip { get; set; } = null!;
        public string? Login { get; set; }
        public string? NomeUsuario { get; set; }

        public virtual Maquina IpNavigation { get; set; } = null!;
    }
}
