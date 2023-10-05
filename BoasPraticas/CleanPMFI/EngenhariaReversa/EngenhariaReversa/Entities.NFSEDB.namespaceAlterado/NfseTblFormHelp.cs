using System;
using System.Collections.Generic;

namespace Domain.Entities.NFSEDB
{
    public partial class NfseTblFormHelp
    {
        public int Idform { get; set; }
        public int Idmenu { get; set; }
        public string? SttextoExplicativo { get; set; }

        public virtual NfseTblMenuHelp IdmenuNavigation { get; set; } = null!;
    }
}
