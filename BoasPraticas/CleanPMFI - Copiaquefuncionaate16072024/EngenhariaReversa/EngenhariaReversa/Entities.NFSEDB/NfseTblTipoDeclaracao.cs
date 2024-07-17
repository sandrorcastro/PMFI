using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.NFSEDB
{
    public partial class NfseTblTipoDeclaracao
    {
        public NfseTblTipoDeclaracao()
        {
            NfseTblDeclaracaoSemMovimentos = new HashSet<NfseTblDeclaracaoSemMovimento>();
        }

        public int Idtipodeclaracao { get; set; }
        public string Stdescricao { get; set; } = null!;
        public string? Stinformacao { get; set; }
        public short? Idtipobaixa { get; set; }

        public virtual ICollection<NfseTblDeclaracaoSemMovimento> NfseTblDeclaracaoSemMovimentos { get; set; }
    }
}
