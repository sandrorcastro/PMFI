using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGProtocoloDB
{
    public partial class CargasProcesso
    {
        public long CargaId { get; set; }
        public DateTime? CargaData { get; set; }
        public long? CargaProcId { get; set; }
        public int? CargaDivisaoIdorigem { get; set; }
        public int? CargaDivisaoId { get; set; }
        public long? CargaServOrigem { get; set; }
        public long? CargaServDestino { get; set; }
        public string? CargaDespacho { get; set; }
        public string? CargaPublicoDivisao { get; set; }
    }
}
