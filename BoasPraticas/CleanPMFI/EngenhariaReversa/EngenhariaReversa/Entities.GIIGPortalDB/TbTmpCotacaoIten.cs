using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGPortalDB
{
    public partial class TbTmpCotacaoIten
    {
        public int? IdFonteDados { get; set; }
        public short? IdEmpresa { get; set; }
        public DateTime? DtExecucao { get; set; }
        public int? IdLicitacao { get; set; }
        public string? NrCnpj { get; set; }
        public string? NmRazaoSocial { get; set; }
        public short? IdModalidade { get; set; }
        public string? DsModalidade { get; set; }
        public int? NrLicitacao { get; set; }
        public DateTime? DtEdital { get; set; }
        public short? NrAno { get; set; }
        public string? NrCnpjcpf { get; set; }
        public string? NmPessoa { get; set; }
        public int? NrLote { get; set; }
        public int? IdItem { get; set; }
        public string? DsItem { get; set; }
        public decimal? NrQuantidade { get; set; }
        public string? NmUnidadeMedida { get; set; }
        public decimal? VlrFechado { get; set; }
    }
}
