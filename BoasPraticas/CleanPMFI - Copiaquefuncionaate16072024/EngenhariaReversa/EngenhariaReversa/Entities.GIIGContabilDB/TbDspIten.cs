using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbDspIten
    {
        public TbDspIten()
        {
            TbCntAtosContratuaisItensLicitacaos = new HashSet<TbCntAtosContratuaisItensLicitacao>();
            TbCntContratosItensLicitacaos = new HashSet<TbCntContratosItensLicitacao>();
            TbCtcCentroCustosItens = new HashSet<TbCtcCentroCustosIten>();
            TbDspEmpenhosItens = new HashSet<TbDspEmpenhosIten>();
            TbDspItensNaturezasDespesas = new HashSet<TbDspItensNaturezasDespesa>();
            TbDspRegistrosNecLicitOrgaosItens = new HashSet<TbDspRegistrosNecLicitOrgaosIten>();
            TbDspRegistrosNecLicitacoesItens = new HashSet<TbDspRegistrosNecLicitacoesIten>();
            TbDspRmsItens = new HashSet<TbDspRmsIten>();
            TbDspSolicitacoesEmpenhoItens = new HashSet<TbDspSolicitacoesEmpenhoIten>();
            TbLicCotacaoItens = new HashSet<TbLicCotacaoIten>();
            TbLicCotacaoSimples = new HashSet<TbLicCotacaoSimple>();
            TbLicFaseLances = new HashSet<TbLicFaseLance>();
            TbLicLicitacoesItens = new HashSet<TbLicLicitacoesIten>();
        }

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
        public virtual ICollection<TbCntAtosContratuaisItensLicitacao> TbCntAtosContratuaisItensLicitacaos { get; set; }
        public virtual ICollection<TbCntContratosItensLicitacao> TbCntContratosItensLicitacaos { get; set; }
        public virtual ICollection<TbCtcCentroCustosIten> TbCtcCentroCustosItens { get; set; }
        public virtual ICollection<TbDspEmpenhosIten> TbDspEmpenhosItens { get; set; }
        public virtual ICollection<TbDspItensNaturezasDespesa> TbDspItensNaturezasDespesas { get; set; }
        public virtual ICollection<TbDspRegistrosNecLicitOrgaosIten> TbDspRegistrosNecLicitOrgaosItens { get; set; }
        public virtual ICollection<TbDspRegistrosNecLicitacoesIten> TbDspRegistrosNecLicitacoesItens { get; set; }
        public virtual ICollection<TbDspRmsIten> TbDspRmsItens { get; set; }
        public virtual ICollection<TbDspSolicitacoesEmpenhoIten> TbDspSolicitacoesEmpenhoItens { get; set; }
        public virtual ICollection<TbLicCotacaoIten> TbLicCotacaoItens { get; set; }
        public virtual ICollection<TbLicCotacaoSimple> TbLicCotacaoSimples { get; set; }
        public virtual ICollection<TbLicFaseLance> TbLicFaseLances { get; set; }
        public virtual ICollection<TbLicLicitacoesIten> TbLicLicitacoesItens { get; set; }
    }
}
