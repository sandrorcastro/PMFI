using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TbTipoSocio
    {
        public TbTipoSocio()
        {
            TbConSolicitacaoInscricaoSocios = new HashSet<TbConSolicitacaoInscricaoSocio>();
        }

        public int TipoSocioId { get; set; }
        public string DsTipoSocio { get; set; } = null!;

        public virtual ICollection<TbConSolicitacaoInscricaoSocio> TbConSolicitacaoInscricaoSocios { get; set; }
    }
}
