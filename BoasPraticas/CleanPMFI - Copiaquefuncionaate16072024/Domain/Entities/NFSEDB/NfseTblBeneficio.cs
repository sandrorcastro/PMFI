using System;
using System.Collections.Generic;

namespace Domain.Entities.NFSEDB
{
    public partial class NfseTblBeneficio
    {
        public NfseTblBeneficio()
        {
            NfseTblContribuintesBeneficios = new HashSet<NfseTblContribuintesBeneficio>();
        }

        public int Id { get; set; }
        public string Descricao { get; set; } = null!;
        public decimal Vldesconto { get; set; }
        public string Stsituacao { get; set; } = null!;

        public virtual ICollection<NfseTblContribuintesBeneficio> NfseTblContribuintesBeneficios { get; set; }
    }
}
