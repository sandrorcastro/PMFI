using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class PortalParametro
    {
        public PortalParametro()
        {
            PortalSecoesPrincipals = new HashSet<PortalSecoesPrincipal>();
        }

        public long Idparam { get; set; }
        public long? IdobjCabecalho { get; set; }
        public long? IdobjRodape { get; set; }
        public string? ParamPadrao { get; set; }
        public string? ParamPeriodo { get; set; }

        public virtual ICollection<PortalSecoesPrincipal> PortalSecoesPrincipals { get; set; }
    }
}
