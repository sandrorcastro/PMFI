using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class PortalObjeto
    {
        public PortalObjeto()
        {
            PortalAgrupamentoPaginas = new HashSet<PortalAgrupamentoPagina>();
            PortalAgrupamentoPrincipals = new HashSet<PortalAgrupamentoPrincipal>();
            PortalIdiomas = new HashSet<PortalIdioma>();
            PortalPublicacoesObjetos = new HashSet<PortalPublicacoesObjeto>();
        }

        public long Idobj { get; set; }
        public byte[]? Objeto { get; set; }
        public string? NomeObj { get; set; }
        public string? Extensao { get; set; }

        public virtual ICollection<PortalAgrupamentoPagina> PortalAgrupamentoPaginas { get; set; }
        public virtual ICollection<PortalAgrupamentoPrincipal> PortalAgrupamentoPrincipals { get; set; }
        public virtual ICollection<PortalIdioma> PortalIdiomas { get; set; }
        public virtual ICollection<PortalPublicacoesObjeto> PortalPublicacoesObjetos { get; set; }
    }
}
