using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TribZonaZoneamentoAtividadeLog
    {
        public int LogId { get; set; }
        public short ZozoId { get; set; }
        public string Atividade { get; set; } = null!;
        public short ZotlId { get; set; }
        public string? Operacao { get; set; }
        public string? Usuario { get; set; }
        public DateTime? Data { get; set; }
    }
}
