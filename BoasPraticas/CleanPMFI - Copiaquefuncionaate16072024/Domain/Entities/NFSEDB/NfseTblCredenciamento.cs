using System;
using System.Collections.Generic;

namespace Domain.Entities.NFSEDB
{
    public partial class NfseTblCredenciamento
    {
        public int Idcredenciamento { get; set; }
        public int Idempresa { get; set; }
        public int Idcontribuinte { get; set; }
        public string Stsituacao { get; set; } = null!;
        public string Idusuario { get; set; } = null!;
        public DateTime Dtinclusao { get; set; }
        public string Idusuarioincluido { get; set; } = null!;
        public string? Stcargo { get; set; }
        public DateTime? Dtdescred { get; set; }

        public virtual NfseTblContribuinte IdcontribuinteNavigation { get; set; } = null!;
        public virtual NfseTblEmpresa IdempresaNavigation { get; set; } = null!;
        public virtual NfseTblUsuario IdusuarioNavigation { get; set; } = null!;
    }
}
