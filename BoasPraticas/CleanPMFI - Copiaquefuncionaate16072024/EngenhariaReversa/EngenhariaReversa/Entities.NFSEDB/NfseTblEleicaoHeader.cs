using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.NFSEDB
{
    public partial class NfseTblEleicaoHeader
    {
        public NfseTblEleicaoHeader()
        {
            NfseTblEleicaoDetalhes = new HashSet<NfseTblEleicaoDetalhe>();
        }

        public int Idarquivo { get; set; }
        public DateTime? DataGeracao { get; set; }
        public string Versao { get; set; } = null!;
        public string NomeLeiaute { get; set; } = null!;
        public string? Nome { get; set; }

        public virtual ICollection<NfseTblEleicaoDetalhe> NfseTblEleicaoDetalhes { get; set; }
    }
}
