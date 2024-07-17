using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class Bkmapapgto
    {
        public long TribMapaPagtoId { get; set; }
        public long TapMapaId { get; set; }
        public long? ImoIddivida { get; set; }
        public long? ConIddivida { get; set; }
        public long? EmpIddivida { get; set; }
        public decimal? TapVlPago { get; set; }
        public decimal? TapVlPrincipal { get; set; }
        public decimal? TapVlJuros { get; set; }
        public decimal? TapVlMulta { get; set; }
        public decimal? TapVlMultaDa { get; set; }
        public decimal? TapVlCorrecao { get; set; }
        public decimal? TapVlDesconto { get; set; }
        public decimal? TapVlJurosParcelas { get; set; }
        public decimal? TapVlAcrescimosAtraso { get; set; }
        public DateTime? DataBaixa { get; set; }
        public DateTime? DataEstorno { get; set; }
        public long? BaiId { get; set; }
        public long? BoleDivId { get; set; }
    }
}
