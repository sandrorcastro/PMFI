using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbLicCotacaoIten
    {
        public TbLicCotacaoIten()
        {
            TbLicCotacaoItensVencedorCancelados = new HashSet<TbLicCotacaoItensVencedorCancelado>();
        }

        public int IdCotacao { get; set; }
        public int IdLicitacao { get; set; }
        public int IdPessoa { get; set; }
        public int? NrLote { get; set; }
        public int? IdItem { get; set; }
        public string? FlCotacao { get; set; }
        public decimal? NrQuantidade { get; set; }
        public decimal? VlUnitario { get; set; }
        public decimal? VlTotal { get; set; }
        public string? DsDetalhamento { get; set; }
        public DateTime? DtCotacao { get; set; }
        public short? IdCondicaoPgto { get; set; }
        public short? IdPrazoEntrega { get; set; }
        public DateTime? DtPrazoEntrega { get; set; }
        public DateTime? DtVencimentoProposta { get; set; }
        public string? FlVencedor { get; set; }
        public short? NrClassificacao { get; set; }
        public decimal? VlTotalNegociado { get; set; }
        public string? DsMarca { get; set; }
        public decimal? VlDesconto { get; set; }
        public DateTime? DtUltAlteracao { get; set; }
        public DateTime? DtInclusao { get; set; }
        public string? DsLogin { get; set; }
        public DateTime? DtHomologacao { get; set; }

        public virtual TbGerCondicoesPagamento? IdCondicaoPgtoNavigation { get; set; }
        public virtual TbDspIten? IdItemNavigation { get; set; }
        public virtual TbLicLicitaco IdLicitacaoNavigation { get; set; } = null!;
        public virtual TbGerPessoa IdPessoaNavigation { get; set; } = null!;
        public virtual TbGerPrazosEntrega? IdPrazoEntregaNavigation { get; set; }
        public virtual ICollection<TbLicCotacaoItensVencedorCancelado> TbLicCotacaoItensVencedorCancelados { get; set; }
    }
}
