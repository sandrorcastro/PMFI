using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class ProdRurTipoRecurso
    {
        public ProdRurTipoRecurso()
        {
            ProdRurRecurPropriedades = new HashSet<ProdRurRecurPropriedade>();
        }

        public int IdtipoRecurso { get; set; }
        public string? Nome { get; set; }
        public int? Idclassificacao { get; set; }

        public virtual ProdRurClassificacaoRecurso? IdclassificacaoNavigation { get; set; }
        public virtual ICollection<ProdRurRecurPropriedade> ProdRurRecurPropriedades { get; set; }
    }
}
