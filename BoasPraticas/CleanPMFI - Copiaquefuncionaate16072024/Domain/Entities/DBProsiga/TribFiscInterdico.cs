using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TribFiscInterdico
    {
        public int InterId { get; set; }
        public short? InterAno { get; set; }
        public int? VistId { get; set; }
        public DateTime? InterData { get; set; }
        public int? FiscalId { get; set; }
        public DateTime? DataInclusao { get; set; }
        public string? UsuarioInclusao { get; set; }
        public int? InterNumero { get; set; }

        public virtual TribFiscFiscai? Fiscal { get; set; }
        public virtual TribFiscVistoria? Vist { get; set; }
    }
}
