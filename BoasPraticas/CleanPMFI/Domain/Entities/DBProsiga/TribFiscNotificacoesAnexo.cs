using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TribFiscNotificacoesAnexo
    {
        public int Anexid { get; set; }
        public int? Notifid { get; set; }
        public int? ObjetoId { get; set; }
        public string? AnexObs { get; set; }
    }
}
