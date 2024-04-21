using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class ProdRurNotaFiscaisCancelada
    {
        public int IdcancNf { get; set; }
        public DateTime? Data { get; set; }
        public int IdnotaFiscal { get; set; }
        public string? Historico { get; set; }

        public virtual ProdRurNotaFiscal IdnotaFiscalNavigation { get; set; } = null!;
    }
}
