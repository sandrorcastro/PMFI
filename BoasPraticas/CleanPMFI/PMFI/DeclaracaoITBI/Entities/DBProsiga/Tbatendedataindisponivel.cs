using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class Tbatendedataindisponivel
{
    public int Iddataindisponivel { get; set; }

    public DateOnly? Data { get; set; }

    public TimeOnly? Horainicial { get; set; }

    public TimeOnly? Horafinal { get; set; }

    public bool? Diainteiro { get; set; }

    public int Idservico { get; set; }
}
