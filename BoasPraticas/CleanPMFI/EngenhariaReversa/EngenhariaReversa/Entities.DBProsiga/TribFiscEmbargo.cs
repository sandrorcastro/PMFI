using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class TribFiscEmbargo
    {
        public int EmbId { get; set; }
        public short? EmbAno { get; set; }
        public DateTime? EmbDataHora { get; set; }
        public string? EmbObs { get; set; }
        public int? VistId { get; set; }
        public int? FiscalId { get; set; }
        public DateTime? DataInclusao { get; set; }
        public string? UsuarioInclusao { get; set; }
        public int? EmbNumero { get; set; }

        public virtual TribFiscFiscai? Fiscal { get; set; }
        public virtual TribFiscVistoria? Vist { get; set; }
    }
}
