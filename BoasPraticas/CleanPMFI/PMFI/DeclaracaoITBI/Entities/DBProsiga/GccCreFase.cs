using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class GccCreFase
{
    public string Cnpjmembro { get; set; } = null!;

    public int CreId { get; set; }

    public int FaseId { get; set; }

    public int Capacidade { get; set; }

    public virtual GccCreche GccCreche { get; set; } = null!;

    public virtual ICollection<GccCriCreche> GccCriCreches { get; set; } = new List<GccCriCreche>();

    public virtual GccFase GccFase { get; set; } = null!;
}
