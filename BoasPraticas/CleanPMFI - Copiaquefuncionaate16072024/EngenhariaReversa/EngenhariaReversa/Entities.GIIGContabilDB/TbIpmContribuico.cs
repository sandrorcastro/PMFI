using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbIpmContribuico
    {
        public int IdGuia { get; set; }
        public int? IdEmpenho { get; set; }
        public int? IdLiquidacao { get; set; }
        public int? IdConsignacao { get; set; }
        public int? IdPagamento { get; set; }
        public int? IdPessoa { get; set; }
        public string? CdOrgao { get; set; }
        public string? CdUnidade { get; set; }
        public int? IdCcgrafica { get; set; }
        public int? IdCcarrecadadora { get; set; }
        public int? IdCcfavorecido { get; set; }
        public string? DsSituacao { get; set; }
        public decimal? VlContribuicao { get; set; }
        public DateTime? DtContribuicao { get; set; }
        public DateTime? DtInclusao { get; set; }
        public string? DsLogin { get; set; }
    }
}
