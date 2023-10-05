using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.NFSEDB
{
    public partial class NfseTblEmpresaRelacionada
    {
        public int Idempresa { get; set; }
        public int Idempresarelacionada { get; set; }
        public int? Idtiporelacao { get; set; }

        public virtual NfseTblEmpresa IdempresaNavigation { get; set; } = null!;
        public virtual NfseTblEmpresa IdempresarelacionadaNavigation { get; set; } = null!;
        public virtual NfseTblEmpresaTipoRelacao? IdtiporelacaoNavigation { get; set; }
    }
}
