using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TmpTribAtivTributosEmpresa
    {
        public string Atividade { get; set; } = null!;
        public int TipoTribId { get; set; }
        public int Tcid { get; set; }
        public string? PeriodoIncidencia { get; set; }
        public string? GeraDividaAutomaticaNoAlvara { get; set; }
        public string IncideNosDomicilioTributario { get; set; } = null!;
        public decimal QtdeUf { get; set; }
        public int? ParamCalcId { get; set; }
    }
}
