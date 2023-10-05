using System;
using System.Collections.Generic;

namespace Domain.Entities.NFSEDB
{
    public partial class NfseTblContribuintesBeneficio
    {
        public long Id { get; set; }
        public int Idbeneficio { get; set; }
        public int Idcontribuinte { get; set; }
        public string Stsituacao { get; set; } = null!;

        public virtual NfseTblBeneficio IdbeneficioNavigation { get; set; } = null!;
        public virtual NfseTblContribuinte IdcontribuinteNavigation { get; set; } = null!;
    }
}
