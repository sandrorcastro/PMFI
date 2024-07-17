using System;
using System.Collections.Generic;

namespace Domain.Entities.NFSEDB
{
    public partial class NfseTblRegimeAliquota
    {
        public byte Idregime { get; set; }
        public decimal Nualiqiss { get; set; }
        public decimal Nualiqpis { get; set; }
        public decimal Nualiqcofins { get; set; }
        public decimal Nualiqcsll { get; set; }
        public decimal Nuvalini { get; set; }
        public decimal Nuvalfim { get; set; }
        public short? Nrordem { get; set; }

        public virtual NfseTblRegime IdregimeNavigation { get; set; } = null!;
    }
}
