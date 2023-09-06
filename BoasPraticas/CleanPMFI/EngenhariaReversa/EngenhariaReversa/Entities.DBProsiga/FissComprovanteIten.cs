using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class FissComprovanteIten
    {
        public long CoItId { get; set; }
        public long? CompId { get; set; }
        public long? DocFisId { get; set; }
        public long? SemMovId { get; set; }

        public virtual FissComprovante? Comp { get; set; }
        public virtual FissDocFiscai? DocFis { get; set; }
        public virtual FissSemMovimento? SemMov { get; set; }
    }
}
