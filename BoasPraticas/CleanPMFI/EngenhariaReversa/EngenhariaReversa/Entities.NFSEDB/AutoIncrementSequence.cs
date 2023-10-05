using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.NFSEDB
{
    public partial class AutoIncrementSequence
    {
        public string Sttabela { get; set; } = null!;
        public short Nuano { get; set; }
        public long? Nucodigo { get; set; }
    }
}
