using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbOrcProgramasAco
{
    public int IdAcao { get; set; }

    public short Idempresa { get; set; }

    public short NrAno { get; set; }

    public string? CdOrgao { get; set; }

    public string? CdUnidade { get; set; }

    public string CdFuncao { get; set; } = null!;

    public string CdSubFuncao { get; set; } = null!;

    public string CdPrograma { get; set; } = null!;

    public string? CdAcao { get; set; }

    public string? DsAcao { get; set; }

    public string? DsQdd { get; set; }

    public decimal? NrMetaLimite { get; set; }

    public decimal? NrMetaExpansao { get; set; }

    public short? IdUnidadeMedida { get; set; }

    public decimal? VlLimite { get; set; }

    public decimal? VlExpansao { get; set; }

    public string? DsJustifLimite { get; set; }

    public string? DsJustifExpansao { get; set; }

    public byte? NrPrioridade { get; set; }

    public DateTime? DtLimite { get; set; }

    public string? DsTipo { get; set; }

    public DateTime? DtCadastro { get; set; }

    public DateTime? DtCancelamento { get; set; }

    public string? DsLoginCancelamento { get; set; }

    public string? FlPlanejamento { get; set; }

    public int? IdPlaAcao { get; set; }

    public int? IdPlaProjetoAtividade { get; set; }

    public int? IdPlaPrograma { get; set; }

    public short? IdProduto { get; set; }

    public short? IdTipoMovimento { get; set; }

    public short? IdTipoAcao { get; set; }

    public virtual ICollection<TbOrcDotaco> TbOrcDotacos { get; set; } = new List<TbOrcDotaco>();

    public virtual TbOrcFunco TbOrcFunco { get; set; } = null!;

    public virtual TbOrcPrograma TbOrcPrograma { get; set; } = null!;

    public virtual ICollection<TbOrcSubAcoesTarefa> TbOrcSubAcoesTarefas { get; set; } = new List<TbOrcSubAcoesTarefa>();

    public virtual TbOrcSubFunco TbOrcSubFunco { get; set; } = null!;

    public virtual ICollection<TbPlaIniciativa> IdIniciativas { get; set; } = new List<TbPlaIniciativa>();

    public virtual ICollection<TbPlaProjetosAtividade> IdProjetoAtividades { get; set; } = new List<TbPlaProjetosAtividade>();
}
