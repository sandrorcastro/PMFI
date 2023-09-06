using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class PortalPublicaco
    {
        public PortalPublicaco()
        {
            PortalPublicacoesObjetos = new HashSet<PortalPublicacoesObjeto>();
        }

        public long Idpublicacao { get; set; }
        public string? Titulo { get; set; }
        public string? Descricao { get; set; }
        public DateTime? DtCad { get; set; }
        public DateTime? DtVal { get; set; }
        public long? Idsecao { get; set; }
        public string? UsuId { get; set; }

        public virtual PortalSecoesPagina? IdsecaoNavigation { get; set; }
        public virtual Usuario? Usu { get; set; }
        public virtual ICollection<PortalPublicacoesObjeto> PortalPublicacoesObjetos { get; set; }
    }
}
