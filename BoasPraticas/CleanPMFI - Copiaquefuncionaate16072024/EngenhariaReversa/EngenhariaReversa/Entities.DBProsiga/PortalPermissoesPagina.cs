using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class PortalPermissoesPagina
    {
        public string UsuId { get; set; } = null!;
        public long Idpaginas { get; set; }
        public DateTime? DtCad { get; set; }
        public DateTime? DtVal { get; set; }

        public virtual PortalSecoesPrincipal IdpaginasNavigation { get; set; } = null!;
        public virtual Usuario Usu { get; set; } = null!;
    }
}
