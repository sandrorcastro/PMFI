using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TribDocumentosIptu
    {
        public long DocIptuid { get; set; }
        public long? EdificacaoId { get; set; }
        public DateTime? DocIptudata { get; set; }
        public string? Usuario { get; set; }
        public string? DocIptudescricao { get; set; }
        public byte[]? DocIptuimagem { get; set; }
        public string? DocIptunumero { get; set; }

        public virtual TribEdificaco? Edificacao { get; set; }
    }
}
