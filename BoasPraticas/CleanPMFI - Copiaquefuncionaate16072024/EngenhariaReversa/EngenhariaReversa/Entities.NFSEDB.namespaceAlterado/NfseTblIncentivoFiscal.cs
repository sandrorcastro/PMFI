using System;
using System.Collections.Generic;

namespace Domain.Entities.NFSEDB
{
    public partial class NfseTblIncentivoFiscal
    {
        public short Idincentivo { get; set; }
        public string? Stnome { get; set; }
        public string? Stdescricao { get; set; }
        public DateTime? Dtinicial { get; set; }
        public DateTime? Dtfinal { get; set; }
        public DateTime? Dtinclusao { get; set; }
        public string? Stusuario { get; set; }
    }
}
