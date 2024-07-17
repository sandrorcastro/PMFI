using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class FissDespachosServidore
{
    public long IdtipoDespacho { get; set; }

    public long ServId { get; set; }

    public virtual ICollection<FissDespachosEmpresa> FissDespachosEmpresas { get; set; } = new List<FissDespachosEmpresa>();

    public virtual FissTiposDespacho IdtipoDespachoNavigation { get; set; } = null!;

    public virtual Servidore Serv { get; set; } = null!;
}
