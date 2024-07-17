using System;
using System.Collections.Generic;

namespace Domain.Entities.NFSEDB
{
    public partial class NfseTblEmpresaTipoTomadore
    {
        public int Idtipotomador { get; set; }
        public int Idempresa { get; set; }
        public string? Stmotivo { get; set; }

        public virtual NfseTblEmpresa IdempresaNavigation { get; set; } = null!;
        public virtual NfseTblTipoTomador IdtipotomadorNavigation { get; set; } = null!;
    }
}
