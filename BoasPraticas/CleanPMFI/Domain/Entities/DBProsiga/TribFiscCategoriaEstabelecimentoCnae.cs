using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TribFiscCategoriaEstabelecimentoCnae
    {
        public int CategEstId { get; set; }
        public string Atividade { get; set; } = null!;

        public virtual TribFiscCategoriaEstabelecimento CategEst { get; set; } = null!;
    }
}
