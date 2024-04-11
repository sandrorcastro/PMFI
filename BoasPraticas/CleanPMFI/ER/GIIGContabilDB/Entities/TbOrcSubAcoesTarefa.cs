using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbOrcSubAcoesTarefa
{
    public int IdSubAcaoTarefa { get; set; }

    public int IdAcao { get; set; }

    public short IdTipoAcao { get; set; }

    public short? IdGrupo { get; set; }

    public int? IdNatDespesa { get; set; }

    public short? IdDistrito { get; set; }

    public string? CdSubAcaoTarefa { get; set; }

    public string? DsSubAcaoTarefa { get; set; }

    public string? DsProduto { get; set; }

    public string? DsResultado { get; set; }

    public int? IdSubAcaoTarefaNivelSuper { get; set; }

    public string? NrLongitude { get; set; }

    public string? NrLatitude { get; set; }

    public DateTime? DtInclusao { get; set; }

    public string? DsLogin { get; set; }

    public DateTime? DtCancelamento { get; set; }

    public string? DsLoginCancelamento { get; set; }

    public int? IdGrupoNaturezas { get; set; }

    public string? CdPrioridade { get; set; }

    public string? DsDenominacao { get; set; }

    public virtual TbOrcProgramasAco IdAcaoNavigation { get; set; } = null!;

    public virtual ICollection<TbOrcDotacoesSubAcoesTarefa> TbOrcDotacoesSubAcoesTarefas { get; set; } = new List<TbOrcDotacoesSubAcoesTarefa>();

    public virtual ICollection<TbOrcProgramasAcoesLoaSubAcoesTarefa> TbOrcProgramasAcoesLoaSubAcoesTarefas { get; set; } = new List<TbOrcProgramasAcoesLoaSubAcoesTarefa>();

    public virtual ICollection<TbOrcSubAcoesMeta> TbOrcSubAcoesMeta { get; set; } = new List<TbOrcSubAcoesMeta>();
}
