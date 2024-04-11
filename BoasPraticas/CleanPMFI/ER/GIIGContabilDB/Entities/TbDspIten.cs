using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbDspIten
{
    public int IdItem { get; set; }

    public string? DsItem { get; set; }

    public short IdUnidadeMedida { get; set; }

    public string? FlAtivo { get; set; }

    public string? FlAceitaCompl { get; set; }

    public short? IdClassificacaoObjeto { get; set; }

    public string? DsLogin { get; set; }

    public DateTime? DtInclusao { get; set; }

    public string? FlPermiteExcederLimite { get; set; }

    public int? IdTipoObjetoDespesa { get; set; }

    public string? DsLoginAlteracao { get; set; }

    public DateTime? DtAlteracao { get; set; }

    public int? IdItemOrigem { get; set; }

    public virtual TbLicClassificacoesObjeto? IdClassificacaoObjetoNavigation { get; set; }

    public virtual TbDspUnidadesMedidum IdUnidadeMedidaNavigation { get; set; } = null!;

    public virtual ICollection<TbCntAtosContratuaisItensLicitacao> TbCntAtosContratuaisItensLicitacaos { get; set; } = new List<TbCntAtosContratuaisItensLicitacao>();

    public virtual ICollection<TbCntContratosItensLicitacao> TbCntContratosItensLicitacaos { get; set; } = new List<TbCntContratosItensLicitacao>();

    public virtual ICollection<TbCtcCentroCustosIten> TbCtcCentroCustosItens { get; set; } = new List<TbCtcCentroCustosIten>();

    public virtual ICollection<TbDspEmpenhosIten> TbDspEmpenhosItens { get; set; } = new List<TbDspEmpenhosIten>();

    public virtual ICollection<TbDspItensNaturezasDespesa> TbDspItensNaturezasDespesas { get; set; } = new List<TbDspItensNaturezasDespesa>();

    public virtual ICollection<TbDspRegistrosNecLicitOrgaosIten> TbDspRegistrosNecLicitOrgaosItens { get; set; } = new List<TbDspRegistrosNecLicitOrgaosIten>();

    public virtual ICollection<TbDspRegistrosNecLicitacoesIten> TbDspRegistrosNecLicitacoesItens { get; set; } = new List<TbDspRegistrosNecLicitacoesIten>();

    public virtual ICollection<TbDspRmsIten> TbDspRmsItens { get; set; } = new List<TbDspRmsIten>();

    public virtual ICollection<TbDspSolicitacoesEmpenhoIten> TbDspSolicitacoesEmpenhoItens { get; set; } = new List<TbDspSolicitacoesEmpenhoIten>();

    public virtual ICollection<TbLicCotacaoIten> TbLicCotacaoItens { get; set; } = new List<TbLicCotacaoIten>();

    public virtual ICollection<TbLicCotacaoSimple> TbLicCotacaoSimples { get; set; } = new List<TbLicCotacaoSimple>();

    public virtual ICollection<TbLicFaseLance> TbLicFaseLances { get; set; } = new List<TbLicFaseLance>();

    public virtual ICollection<TbLicLicitacoesIten> TbLicLicitacoesItens { get; set; } = new List<TbLicLicitacoesIten>();
}
