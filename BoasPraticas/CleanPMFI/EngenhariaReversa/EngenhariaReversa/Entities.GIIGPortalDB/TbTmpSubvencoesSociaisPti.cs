using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGPortalDB
{
    public partial class TbTmpSubvencoesSociaisPti
    {
        public int? Id { get; set; }
        public string? NrCnpj { get; set; }
        public string? DsTipoExecucao { get; set; }
        public int? IdSubVencaoSocial { get; set; }
        public int? CdSubvencaoSocial { get; set; }
        public int? NrAno { get; set; }
        public string? DsTpEntidade { get; set; }
        public string? NrCnpjcpf { get; set; }
        public string? NmPessoa { get; set; }
        public string? Órgão { get; set; }
        public DateTime? DtCelebracao { get; set; }
        public string? DsLeiAutorizatoria { get; set; }
        public DateTime? DtInicioConvenio { get; set; }
        public DateTime? DtPrazoFinal { get; set; }
        public string? DsObjeto { get; set; }
        public string? DsUnidadeMedida { get; set; }
        public int? NrQtdPrevista { get; set; }
        public decimal? VlPrevisto { get; set; }
        public decimal? VlAditivos { get; set; }
        public string? Dotacao { get; set; }
        public decimal? VlEmpenhado { get; set; }
        public decimal? VlrPagamento { get; set; }
        public decimal? VlrEstornoPagamento { get; set; }
        public string? TpResultadoConclusivo { get; set; }
        public decimal? VlContrapartida { get; set; }
        public int? NumeroAditivoVigente { get; set; }
    }
}
