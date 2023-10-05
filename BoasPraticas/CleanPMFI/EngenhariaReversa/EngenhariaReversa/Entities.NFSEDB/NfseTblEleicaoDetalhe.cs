using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.NFSEDB
{
    public partial class NfseTblEleicaoDetalhe
    {
        public int Ideleicao { get; set; }
        public int Idarquivo { get; set; }
        public string? TipoPrestador { get; set; }
        public string? Cnpj { get; set; }
        public string? Nome { get; set; }
        public string? NaturezaJuridica { get; set; }
        public string? CnaePrincipal { get; set; }
        public DateTime? DataInsercao { get; set; }

        public virtual NfseTblEleicaoHeader IdarquivoNavigation { get; set; } = null!;
    }
}
