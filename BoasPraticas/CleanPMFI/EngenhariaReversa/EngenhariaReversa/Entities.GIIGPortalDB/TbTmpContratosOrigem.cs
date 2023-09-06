using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGPortalDB
{
    public partial class TbTmpContratosOrigem
    {
        public int? IdFonteDados { get; set; }
        public short? IdEmpresa { get; set; }
        public DateTime? DtExecucao { get; set; }
        public string? NrCnpj { get; set; }
        public string? NmRazaoSocial { get; set; }
        public short? CdTipoAtoContratual { get; set; }
        public string? TipoAtoContratual { get; set; }
        public string? DsTipoContrato { get; set; }
        public int? IdContrato { get; set; }
        public short? NrAno { get; set; }
        public int? NrContrato { get; set; }
        public DateTime? DtContrato { get; set; }
        public DateTime? DtAssinatura { get; set; }
        public string? CdOrgao { get; set; }
        public string? NmOrgao { get; set; }
        public string? NrCnpjcpf { get; set; }
        public string? NmPessoa { get; set; }
        public string? DsObjeto { get; set; }
        public DateTime? DtInicioPrazo { get; set; }
        public DateTime? DtTerminoPrazo { get; set; }
        public decimal? VlContrato { get; set; }
        public short? IdModalidade { get; set; }
        public string? DsModalidade { get; set; }
        public int? NrLicitacao { get; set; }
        public short? NrAnoLicitacao { get; set; }
        public decimal? VlAditivos { get; set; }
        public DateTime? DtNovaTermino { get; set; }
        public string? Administrador { get; set; }
        public string? CodigoLicitacao { get; set; }
        public decimal? ValorDoContratoOriginal { get; set; }
        public decimal? ValorDoTermoAditivo { get; set; }
        public decimal? ValorTotal { get; set; }
        public int? NumeroAditivoVigente { get; set; }
        public string? SetorFiscalizacao { get; set; }
        public string? TipoSituacaoContrato { get; set; }
    }
}
