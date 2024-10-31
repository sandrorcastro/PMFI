using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class SaudeConfigSaldoEstoque
    {
        public long IdConfiguracao { get; set; }
        public long? IdEstoque { get; set; }
        public long? IdMedicamentos { get; set; }
        public decimal? Minimo { get; set; }
        public decimal? Maximo { get; set; }
    }
}
