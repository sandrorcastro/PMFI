using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGProtocoloDB
{
    public partial class Recebimento
    {
        public long RecId { get; set; }
        public long? RecServidorId { get; set; }
        public DateTime? RecData { get; set; }
        public long? RecCargaId { get; set; }
        public string RecSituacao { get; set; } = null!;
        public long RecIdrecebimento { get; set; }
    }
}
