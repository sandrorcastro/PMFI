using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGConsultaPreviaDB
{
    public partial class TabTipoContribuinte
    {
        public TabTipoContribuinte()
        {
            TabConsultaDados = new HashSet<TabConsultaDado>();
            TabContribuintePermissaos = new HashSet<TabContribuintePermissao>();
            Docus = new HashSet<TabDocumento>();
        }

        public short IdTipoContribuinte { get; set; }
        public string NmTipoContribuinte { get; set; } = null!;
        public string FlFormalizarTipoContribuinte { get; set; } = null!;

        public virtual ICollection<TabConsultaDado> TabConsultaDados { get; set; }
        public virtual ICollection<TabContribuintePermissao> TabContribuintePermissaos { get; set; }

        public virtual ICollection<TabDocumento> Docus { get; set; }
    }
}
