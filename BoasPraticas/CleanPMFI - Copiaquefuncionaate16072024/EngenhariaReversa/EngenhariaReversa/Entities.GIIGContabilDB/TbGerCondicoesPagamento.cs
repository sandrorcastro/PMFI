using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbGerCondicoesPagamento
    {
        public TbGerCondicoesPagamento()
        {
            TbCntContratos = new HashSet<TbCntContrato>();
            TbDspEmpenhos = new HashSet<TbDspEmpenho>();
            TbDspSolicitacoesEmpenhos = new HashSet<TbDspSolicitacoesEmpenho>();
            TbLicCotacaoItens = new HashSet<TbLicCotacaoIten>();
            TbLicLicitacoesItens = new HashSet<TbLicLicitacoesIten>();
            TbLicLicitacos = new HashSet<TbLicLicitaco>();
        }

        public short IdCondicaoPgto { get; set; }
        public string? DsCondicaoPgto { get; set; }
        public short? CdTc { get; set; }
        public bool? FlAtivo { get; set; }

        public virtual ICollection<TbCntContrato> TbCntContratos { get; set; }
        public virtual ICollection<TbDspEmpenho> TbDspEmpenhos { get; set; }
        public virtual ICollection<TbDspSolicitacoesEmpenho> TbDspSolicitacoesEmpenhos { get; set; }
        public virtual ICollection<TbLicCotacaoIten> TbLicCotacaoItens { get; set; }
        public virtual ICollection<TbLicLicitacoesIten> TbLicLicitacoesItens { get; set; }
        public virtual ICollection<TbLicLicitaco> TbLicLicitacos { get; set; }
    }
}
