using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TribFiscOrdemFiscalizacaoAnexo
    {
        public int AnexoId { get; set; }
        public int? FiscOfid { get; set; }
        public int? ObjetoId { get; set; }
        public string? AnexoObs { get; set; }
    }
}
