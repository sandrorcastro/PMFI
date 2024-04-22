using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TribFiscCategoriaEstabelecimento
    {
        public TribFiscCategoriaEstabelecimento()
        {
            TribFiscCategoriaEstabelecimentoCnaes = new HashSet<TribFiscCategoriaEstabelecimentoCnae>();
            TribFiscProcedimentos = new HashSet<TribFiscProcedimento>();
        }

        public int CategEstId { get; set; }
        public string? CategEstCodigo { get; set; }
        public string? CategEstDescricao { get; set; }

        public virtual ICollection<TribFiscCategoriaEstabelecimentoCnae> TribFiscCategoriaEstabelecimentoCnaes { get; set; }
        public virtual ICollection<TribFiscProcedimento> TribFiscProcedimentos { get; set; }
    }
}
