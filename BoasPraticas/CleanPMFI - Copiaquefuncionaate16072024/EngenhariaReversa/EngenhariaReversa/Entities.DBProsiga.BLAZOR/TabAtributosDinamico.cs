using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class TabAtributosDinamico
    {
        public TabAtributosDinamico()
        {
            TribEdifAtributosDinamicos = new HashSet<TribEdifAtributosDinamico>();
        }

        public int TabParId { get; set; }
        public string? TabParTabela { get; set; }
        public string? TabParTipo { get; set; }
        public string? TabParNome { get; set; }

        public virtual ICollection<TribEdifAtributosDinamico> TribEdifAtributosDinamicos { get; set; }
    }
}
