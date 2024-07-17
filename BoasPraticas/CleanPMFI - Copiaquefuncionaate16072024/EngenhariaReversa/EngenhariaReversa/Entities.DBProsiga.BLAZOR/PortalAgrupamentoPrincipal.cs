using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class PortalAgrupamentoPrincipal
    {
        public PortalAgrupamentoPrincipal()
        {
            PortalSecoesPrincipals = new HashSet<PortalSecoesPrincipal>();
        }

        public long IdagrupaPrincipal { get; set; }
        public string? NomeAgrupaPrinc { get; set; }
        public string? Posicao { get; set; }
        public long? Idobj { get; set; }
        public long? Ididioma { get; set; }
        public DateTime? DtCad { get; set; }
        public DateTime? DtVal { get; set; }
        public int? Ordem { get; set; }

        public virtual PortalIdioma? IdidiomaNavigation { get; set; }
        public virtual PortalObjeto? IdobjNavigation { get; set; }
        public virtual ICollection<PortalSecoesPrincipal> PortalSecoesPrincipals { get; set; }
    }
}
