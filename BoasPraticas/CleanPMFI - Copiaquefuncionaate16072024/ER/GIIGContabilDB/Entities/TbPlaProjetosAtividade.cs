using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbPlaProjetosAtividade
{
    public int IdProjetoAtividade { get; set; }

    public short? IdEscopo { get; set; }

    public short? IdVersaoCriacao { get; set; }

    public short? NrAno { get; set; }

    public string? CdProjetoAtividade { get; set; }

    public string? DsProjetoAtividade { get; set; }

    public DateTime? DtInclusao { get; set; }

    public string? DsLogin { get; set; }

    public string? TpProjetoAtividade { get; set; }

    public string? FlOrcamentaria { get; set; }

    public virtual ICollection<TbPlaProjetosAtividadesAco> TbPlaProjetosAtividadesAcos { get; set; } = new List<TbPlaProjetosAtividadesAco>();

    public virtual ICollection<TbOrcProgramasAco> IdAcaos { get; set; } = new List<TbOrcProgramasAco>();

    public virtual ICollection<TbPlaObjetivosMeta> IdObjetivoMeta { get; set; } = new List<TbPlaObjetivosMeta>();
}
