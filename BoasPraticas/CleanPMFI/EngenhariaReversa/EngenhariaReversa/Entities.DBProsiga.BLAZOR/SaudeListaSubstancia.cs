using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class SaudeListaSubstancia
    {
        public SaudeListaSubstancia()
        {
            SaudeMedicamentoXxxxxxes = new HashSet<SaudeMedicamentoXxxxxx>();
        }

        public int ListaId { get; set; }
        public string? NomeLista { get; set; }
        public string? Substancia { get; set; }

        public virtual ICollection<SaudeMedicamentoXxxxxx> SaudeMedicamentoXxxxxxes { get; set; }
    }
}
