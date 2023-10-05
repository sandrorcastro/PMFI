using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.NFSEDB
{
    public partial class DesifIdentificacaoServicosRemuneracaoVariavel
    {
        public int Idserremvar { get; set; }
        public int Iddeclaracao { get; set; }
        public string Idservremvar { get; set; } = null!;
        public string? Stdesccomple { get; set; }
        public string Stsubtitulo { get; set; } = null!;
    }
}
