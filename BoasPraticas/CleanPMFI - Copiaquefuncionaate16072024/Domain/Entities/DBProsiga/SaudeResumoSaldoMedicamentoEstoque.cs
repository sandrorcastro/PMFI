using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class SaudeResumoSaldoMedicamentoEstoque
    {
        public int CdEstoque { get; set; }
        public int CdMedicamento { get; set; }
        public int Trimestre { get; set; }
        public int Ano { get; set; }
        public int? QtdEntrada { get; set; }
        public int? QtdSaida { get; set; }
        public int? QtdPerda { get; set; }
        public int? QtdEstoqueFinal { get; set; }
    }
}
