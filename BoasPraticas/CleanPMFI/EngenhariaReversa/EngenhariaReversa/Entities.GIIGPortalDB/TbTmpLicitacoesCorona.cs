using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGPortalDB
{
    public partial class TbTmpLicitacoesCorona
    {
        public int? IdFonteDados { get; set; }
        public short? IdEmpresa { get; set; }
        public DateTime? DtExecucao { get; set; }
        public string? NrCnpj { get; set; }
        public string? NmRazaoSocial { get; set; }
        public int? IdLicitacao { get; set; }
        public short? Nrano { get; set; }
        public int? NrLicitacao { get; set; }
        public string? DsObjeto { get; set; }
        public string? DsModalidade { get; set; }
        public string? NmPessoa { get; set; }
        public string? NrCnpjcpf { get; set; }
        public string? DsRegimeExecucao { get; set; }
        public string? DsTipoAvaliacao { get; set; }
        public string? DsClassificacaoObjeto { get; set; }
        public decimal? VlMaximo { get; set; }
        public string? CdNatDespesa { get; set; }
    }
}
