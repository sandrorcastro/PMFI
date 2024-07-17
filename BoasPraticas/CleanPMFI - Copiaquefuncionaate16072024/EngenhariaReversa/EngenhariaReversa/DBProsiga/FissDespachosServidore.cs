using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class FissDespachosServidore
    {
        public FissDespachosServidore()
        {
            FissDespachosEmpresas = new HashSet<FissDespachosEmpresa>();
        }

        public long IdtipoDespacho { get; set; }
        public long ServId { get; set; }

        public virtual FissTiposDespacho IdtipoDespachoNavigation { get; set; } = null!;
        public virtual Servidore Serv { get; set; } = null!;
        public virtual ICollection<FissDespachosEmpresa> FissDespachosEmpresas { get; set; }
    }
}
