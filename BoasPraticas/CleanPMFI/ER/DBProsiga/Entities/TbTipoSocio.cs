using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TbTipoSocio
{
    public int TipoSocioId { get; set; }

    public string DsTipoSocio { get; set; } = null!;

    public virtual ICollection<TbConSolicitacaoInscricaoSocio> TbConSolicitacaoInscricaoSocios { get; set; } = new List<TbConSolicitacaoInscricaoSocio>();
}
