using System;
using System.Collections.Generic;

namespace Domain.Entities.NFSEDB
{
    public partial class NfseTblLog
    {
        public long Idlog { get; set; }
        public string? Idusuario { get; set; }
        public int? Idempresa { get; set; }
        public string? Sturlanterior { get; set; }
        public string? Sturl { get; set; }
        public string? Stuseragent { get; set; }
        public string Stuserhostname { get; set; } = null!;
        public string? Stuserhostaddress { get; set; }
        public string? Staction { get; set; }
        public string? Stcontroller { get; set; }
        public DateTime Dtdata { get; set; }

        public virtual NfseTblEmpresa? IdempresaNavigation { get; set; }
        public virtual NfseTblUsuario? IdusuarioNavigation { get; set; }
    }
}
