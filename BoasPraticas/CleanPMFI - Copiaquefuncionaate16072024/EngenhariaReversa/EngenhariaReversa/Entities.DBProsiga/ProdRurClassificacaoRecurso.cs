using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class ProdRurClassificacaoRecurso
    {
        public ProdRurClassificacaoRecurso()
        {
            ProdRurTipoRecursos = new HashSet<ProdRurTipoRecurso>();
        }

        public int Idclassificacao { get; set; }
        public string? Nome { get; set; }

        public virtual ICollection<ProdRurTipoRecurso> ProdRurTipoRecursos { get; set; }
    }
}
