using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class FzboletosErro
    {
        public string BoleNossoNumero { get; set; } = null!;
        public DateTime? DataBaixa { get; set; }
        public DateTime? DataVencimento { get; set; }
        public decimal? ValorBoleto { get; set; }
        public string? BoleErro { get; set; }
        public string? BoleArquivo { get; set; }
        public DateTime? BoleDataInclusao { get; set; }
        public string? BoleUsuarioInclusao { get; set; }
        public int? ConvenioId { get; set; }
    }
}
