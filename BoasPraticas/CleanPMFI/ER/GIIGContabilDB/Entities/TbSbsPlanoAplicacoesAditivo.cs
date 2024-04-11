using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbSbsPlanoAplicacoesAditivo
{
    public int IdPlanoAditivo { get; set; }

    public int? IdEmpresa { get; set; }

    public int? IdSubvencaoSocial { get; set; }

    public int? IdAditivo { get; set; }

    public int? IdNatDespesa { get; set; }

    public decimal? VlPlanoAplicacao { get; set; }

    public int? IdCatDespesa { get; set; }

    public string? DsLogin { get; set; }

    public DateTime? DtInclusao { get; set; }

    public virtual TbSbsCategoriasDespesa? IdCatDespesaNavigation { get; set; }

    public virtual TbOrcNaturezasDespesa? IdNatDespesaNavigation { get; set; }

    public virtual TbSbsSubvencaoSocial? IdSubvencaoSocialNavigation { get; set; }
}
