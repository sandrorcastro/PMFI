using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbPlaObjetivosMeta
{
    public int IdObjetivoMeta { get; set; }

    public string? DsMetaFisica { get; set; }

    public string? FlMetaQuantitativa { get; set; }

    public int IdObjetivo { get; set; }

    public virtual TbPlaObjetivo IdObjetivoNavigation { get; set; } = null!;

    public virtual ICollection<TbPlaObjetivosMetasLocalizadore> TbPlaObjetivosMetasLocalizadores { get; set; } = new List<TbPlaObjetivosMetasLocalizadore>();

    public virtual ICollection<TbPlaProjetosAtividade> IdProjetoAtividades { get; set; } = new List<TbPlaProjetosAtividade>();
}
