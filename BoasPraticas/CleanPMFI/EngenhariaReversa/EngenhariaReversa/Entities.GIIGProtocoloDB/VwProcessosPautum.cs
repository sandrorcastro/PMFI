using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGProtocoloDB
{
    public partial class VwProcessosPautum
    {
        public DateTime? ProcData { get; set; }
        public short? ProcAno { get; set; }
        public int? ProcSequencia { get; set; }
        public short AssuId { get; set; }
        public string? AssuNome { get; set; }
        public string? ProcComplemento { get; set; }
        public string? PessCpfcnpj { get; set; }
        public string? PessNome { get; set; }
    }
}
