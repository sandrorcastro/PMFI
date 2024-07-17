using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGProtocoloDB
{
    public partial class TabUsuarioAssunto
    {
        public string Usuario { get; set; } = null!;
        public short AssuId { get; set; }

        public virtual TabAssunto Assu { get; set; } = null!;
    }
}
