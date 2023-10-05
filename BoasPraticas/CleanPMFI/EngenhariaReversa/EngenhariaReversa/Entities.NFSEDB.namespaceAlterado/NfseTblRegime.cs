using System;
using System.Collections.Generic;

namespace Domain.Entities.NFSEDB
{
    public partial class NfseTblRegime
    {
        public NfseTblRegime()
        {
            NfseTblRegimeAliquota = new HashSet<NfseTblRegimeAliquota>();
        }

        public byte Idregime { get; set; }
        public string Stnomeregime { get; set; } = null!;
        public string? Stdescregime { get; set; }
        public string? Sttipoaliquota { get; set; }
        public string Stsimpnac { get; set; } = null!;
        public string Stgeradam { get; set; } = null!;
        public string Sttomretemiss { get; set; } = null!;
        public byte? Nuordem { get; set; }
        public string? Flativo { get; set; }

        public virtual ICollection<NfseTblRegimeAliquota> NfseTblRegimeAliquota { get; set; }
    }
}
