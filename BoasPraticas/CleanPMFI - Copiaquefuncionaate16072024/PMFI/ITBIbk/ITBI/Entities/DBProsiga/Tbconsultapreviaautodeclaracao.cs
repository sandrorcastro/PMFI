using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class Tbconsultapreviaautodeclaracao
{
    public int Idconsulta { get; set; }

    public int Idautodeclaracao { get; set; }

    public DateTime Dtaceite { get; set; }

    public int Idusuarioaceite { get; set; }
}
