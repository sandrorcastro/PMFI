using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TribItbiexAvaliacao
    {
        public int ItbiavalId { get; set; }
        public long? Itbiid { get; set; }
        public long? Itbiproximo { get; set; }
        public long? EdificacaoId { get; set; }
        public byte[]? ItbiavalImgItbi { get; set; }
        public byte[]? ItbiavalImgBci { get; set; }

        public virtual TribItbiex? Itbi { get; set; }
    }
}
