using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class TempTribAtivTributosEmpresa
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
