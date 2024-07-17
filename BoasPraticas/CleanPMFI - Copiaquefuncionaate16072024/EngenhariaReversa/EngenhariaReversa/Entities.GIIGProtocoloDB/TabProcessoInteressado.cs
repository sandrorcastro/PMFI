using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGProtocoloDB
{
    public partial class TabProcessoInteressado
    {
        public int InteId { get; set; }
        public long? ProcId { get; set; }
        public int? PessId { get; set; }
        public int? Idusuario { get; set; }

        public virtual TabPessoa? Pess { get; set; }
        public virtual TabProcesso? Proc { get; set; }
    }
}
