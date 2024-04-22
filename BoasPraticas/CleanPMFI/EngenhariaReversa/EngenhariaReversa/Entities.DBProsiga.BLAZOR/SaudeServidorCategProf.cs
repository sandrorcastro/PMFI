using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class SaudeServidorCategProf
    {
        public SaudeServidorCategProf()
        {
            SaudeEscalas = new HashSet<SaudeEscala>();
        }

        public long IdServidor { get; set; }
        public long IdCategoria { get; set; }
        public string? NumRegClasse { get; set; }

        public virtual TribCategProfissional IdCategoriaNavigation { get; set; } = null!;
        public virtual Servidore IdServidorNavigation { get; set; } = null!;
        public virtual ICollection<SaudeEscala> SaudeEscalas { get; set; }
    }
}
