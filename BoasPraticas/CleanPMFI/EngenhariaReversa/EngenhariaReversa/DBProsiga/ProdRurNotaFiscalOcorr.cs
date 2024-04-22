using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class ProdRurNotaFiscalOcorr
    {
        public int IdocorNf { get; set; }
        public DateTime? Data { get; set; }
        public string? TipoOcor { get; set; }
        public string? Historico { get; set; }
        public string UsuId { get; set; } = null!;
        public int? IdnotaFiscal { get; set; }

        public virtual ProdRurNotaFiscal? IdnotaFiscalNavigation { get; set; }
        public virtual Usuario Usu { get; set; } = null!;
    }
}
