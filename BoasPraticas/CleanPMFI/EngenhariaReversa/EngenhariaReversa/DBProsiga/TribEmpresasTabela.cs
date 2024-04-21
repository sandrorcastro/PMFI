using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TribEmpresasTabela
    {
        public TribEmpresasTabela()
        {
            TribEmpresasTabelaValorCalcs = new HashSet<TribEmpresasTabelaValorCalc>();
        }

        public int TabelaId { get; set; }
        public string? TabelaNome { get; set; }
        public string? TabelaTipo { get; set; }
        public string? TabelaDescricao { get; set; }

        public virtual ICollection<TribEmpresasTabelaValorCalc> TribEmpresasTabelaValorCalcs { get; set; }
    }
}
