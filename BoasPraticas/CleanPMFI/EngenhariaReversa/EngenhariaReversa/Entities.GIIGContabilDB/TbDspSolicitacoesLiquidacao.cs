using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbDspSolicitacoesLiquidacao
    {
        public int IdSolicitacao { get; set; }
        public int? IdEmpenho { get; set; }
        public decimal? VlSolicitacao { get; set; }
        public string? DsSoliticacao { get; set; }
        public string? DsSituacao { get; set; }
        public string? CdOrgao { get; set; }
        public string? CdUnidade { get; set; }
        public string? DsLogin { get; set; }
        public string? DsEnderecoIp { get; set; }
        public DateTime? DtInclusao { get; set; }
        public decimal? VlLiberado { get; set; }
        public string? DsParecer { get; set; }
        public string? DsLoginParecer { get; set; }
        public DateTime? DtParecer { get; set; }
    }
}
