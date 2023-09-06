using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGPortalDB
{
    public partial class TbTmpPagamentosAssistSocialParceria
    {
        public int? IdFonteDados { get; set; }
        public short? IdEmpresa { get; set; }
        public DateTime? DtExecucao { get; set; }
        public string? NrCnpj { get; set; }
        public string? NmRazaoSocial { get; set; }
        public string? NmPessoa { get; set; }
        public string? NrCnpjcpf { get; set; }
        public int? NrTermo { get; set; }
        public int? NrAnoSubvencao { get; set; }
        public string? DsObjeto { get; set; }
        public decimal? VlPrevisto { get; set; }
        public decimal? VlAditivos { get; set; }
        public string? NrSequencia { get; set; }
        public decimal? VlPagamento { get; set; }
        public short? MesCompetencia { get; set; }
        public decimal? VlPagamentoDocto { get; set; }
        public DateTime? DtPagamento { get; set; }
        public short? NrAno { get; set; }
        public string? CdFonte { get; set; }
        public string? DsFonte { get; set; }
        public int? IdRecurso { get; set; }
        public string? DsRecurso { get; set; }
        public string? NmCc { get; set; }
        public string? NrCc { get; set; }
    }
}
