using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbOrcNaturezasDespesa
{
    public int IdNatDespesa { get; set; }

    public short? IdEmpresa { get; set; }

    public short NrAno { get; set; }

    public string? CdNatDespesa { get; set; }

    public string? DsNatDespesa { get; set; }

    public string? DsEspecificacao { get; set; }

    public string? FlNatDespesaPadrao { get; set; }

    public string? DsTipoNatDespesaPadrao { get; set; }

    public DateTime? DtCadastro { get; set; }

    public DateTime? DtDesativacao { get; set; }

    public int? IdNatDespesaNivelSuper { get; set; }

    public virtual TbOrcNaturezasDespesa? IdNatDespesaNivelSuperNavigation { get; set; }

    public virtual ICollection<TbOrcNaturezasDespesa> InverseIdNatDespesaNivelSuperNavigation { get; set; } = new List<TbOrcNaturezasDespesa>();

    public virtual ICollection<TbDspEmpenho> TbDspEmpenhos { get; set; } = new List<TbDspEmpenho>();

    public virtual ICollection<TbOrcDotaco> TbOrcDotacos { get; set; } = new List<TbOrcDotaco>();

    public virtual ICollection<TbOrcSolicitacoesSaldoDotacao> TbOrcSolicitacoesSaldoDotacaos { get; set; } = new List<TbOrcSolicitacoesSaldoDotacao>();

    public virtual ICollection<TbSbsCronogramaDesembolsoAditivo> TbSbsCronogramaDesembolsoAditivos { get; set; } = new List<TbSbsCronogramaDesembolsoAditivo>();

    public virtual ICollection<TbSbsPlanoAplicacoesAditivo> TbSbsPlanoAplicacoesAditivos { get; set; } = new List<TbSbsPlanoAplicacoesAditivo>();
}
