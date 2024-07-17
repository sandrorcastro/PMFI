using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class PortalIdioma
    {
        public PortalIdioma()
        {
            PortalAgrupamentoPrincipals = new HashSet<PortalAgrupamentoPrincipal>();
        }

        public long Ididioma { get; set; }
        public string? Idioma { get; set; }
        public long? Idobj { get; set; }
        public int? AcessosPrincipal { get; set; }

        public virtual PortalObjeto? IdobjNavigation { get; set; }
        public virtual ICollection<PortalAgrupamentoPrincipal> PortalAgrupamentoPrincipals { get; set; }
    }
}
