using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGProtocoloDB
{
    public partial class TabModeloAssunto
    {
        public int ModeId { get; set; }
        public short AssuId { get; set; }
        public string? MoasDescricao { get; set; }

        public virtual TabAssunto Assu { get; set; } = null!;
        public virtual TabModelo Mode { get; set; } = null!;
    }
}
