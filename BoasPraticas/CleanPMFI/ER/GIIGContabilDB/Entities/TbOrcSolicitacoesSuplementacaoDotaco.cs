using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbOrcSolicitacoesSuplementacaoDotaco
{
    public int IdSolicitacaoDotacao { get; set; }

    public int IdSolicitacao { get; set; }

    public int IdDotacao { get; set; }

    public int? IdSubAcaoTarefa { get; set; }

    public string? DsTipo { get; set; }

    public decimal? VlAlteracao { get; set; }

    public short? IdTipoRecurso { get; set; }

    public virtual TbOrcDotaco IdDotacaoNavigation { get; set; } = null!;

    public virtual TbOrcSolicitacoesSuplementacao IdSolicitacaoNavigation { get; set; } = null!;

    public virtual ICollection<TbOrcAlteracoesOrcamentaria> IdAlteracaos { get; set; } = new List<TbOrcAlteracoesOrcamentaria>();
}
