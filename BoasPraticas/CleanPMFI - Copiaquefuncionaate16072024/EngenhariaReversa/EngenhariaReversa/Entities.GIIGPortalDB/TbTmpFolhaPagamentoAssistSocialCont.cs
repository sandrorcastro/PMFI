using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGPortalDB
{
    public partial class TbTmpFolhaPagamentoAssistSocialCont
    {
        public int? IdFonteDados { get; set; }
        public short? IdEmpresa { get; set; }
        public DateTime? DtExecucao { get; set; }
        public string? NmPessoa { get; set; }
        public string? NrCnpjcpf { get; set; }
        public int? NrContrato { get; set; }
        public short? NrAno { get; set; }
        public string? DsObjeto { get; set; }
        public decimal? VlContrato { get; set; }
        public decimal? ValorAtualizado { get; set; }
        public int? Parcela { get; set; }
        public short? MesCompetencia { get; set; }
        public string? NmCc { get; set; }
        public string? NrCc { get; set; }
        public decimal? ValorPago { get; set; }
        public DateTime? DataPagamento { get; set; }
        public string? CdFonte { get; set; }
        public string? BlocoPrograma { get; set; }
        public string? CdNatDespesa { get; set; }
        public string? DsNatDespesa { get; set; }
    }
}
