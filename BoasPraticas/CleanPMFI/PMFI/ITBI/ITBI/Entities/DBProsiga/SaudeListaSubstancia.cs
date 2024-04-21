using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class SaudeListaSubstancia
{
    public int ListaId { get; set; }

    public string? NomeLista { get; set; }

    public string? Substancia { get; set; }

    public virtual ICollection<SaudeMedicamentoXxxxxx> SaudeMedicamentoXxxxxxes { get; set; } = new List<SaudeMedicamentoXxxxxx>();
}
