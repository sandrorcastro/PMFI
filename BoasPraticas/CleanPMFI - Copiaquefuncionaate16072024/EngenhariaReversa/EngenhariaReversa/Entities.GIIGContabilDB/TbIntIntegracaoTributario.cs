using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbIntIntegracaoTributario
    {
        public int IdLancamento { get; set; }
        public short? IdEmpresa { get; set; }
        public DateTime? DtLancamento { get; set; }
        public string? TpLancamento { get; set; }
        public string? TpCredito { get; set; }
        public string? DsCredito { get; set; }
        public string? CdReceita { get; set; }
        public decimal? VlLancamento { get; set; }
        public DateTime? DtInclusao { get; set; }
        public string? CdOrgao { get; set; }
        public string? CdUnidade { get; set; }
        public short? IdTipoOperacaoReceita { get; set; }
    }
}
