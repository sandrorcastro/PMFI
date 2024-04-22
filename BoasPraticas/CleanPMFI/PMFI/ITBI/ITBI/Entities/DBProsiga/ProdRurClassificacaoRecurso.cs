using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class ProdRurClassificacaoRecurso
{
    public int Idclassificacao { get; set; }

    public string? Nome { get; set; }

    public virtual ICollection<ProdRurTipoRecurso> ProdRurTipoRecursos { get; set; } = new List<ProdRurTipoRecurso>();
}
