using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbOrcQuotasOrcamentaria
{
    public int IdQuota { get; set; }

    public short? IdEmpresa { get; set; }

    public short? NrAno { get; set; }

    public int? IdFonte { get; set; }

    public short? IdGrupo { get; set; }

    public DateTime? DtMovimento { get; set; }

    public string? CdOrgao { get; set; }

    public string? CdUnidade { get; set; }

    public int? IdAcao { get; set; }

    public int? IdDotacao { get; set; }

    public int? IdRecurso { get; set; }

    public string? FlTipo { get; set; }

    public decimal? VlQuota { get; set; }

    public string? DsHistorico { get; set; }

    public DateTime? DtInclusao { get; set; }

    public string? DsLogin { get; set; }

    public int? IdSolicitacao { get; set; }

    public virtual TbOrcGruposQuota? IdGrupoNavigation { get; set; }

    public virtual TbOrcSolicitacoesQuota? IdSolicitacaoNavigation { get; set; }
}
