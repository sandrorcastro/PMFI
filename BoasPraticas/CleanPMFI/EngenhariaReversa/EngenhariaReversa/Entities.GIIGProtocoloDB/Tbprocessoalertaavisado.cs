using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGProtocoloDB
{
    public partial class Tbprocessoalertaavisado
    {
        public long ProcId { get; set; }
        public long MoviId { get; set; }
        public int Idusuario { get; set; }
        public DateTime? Dtleitura { get; set; }
    }
}
