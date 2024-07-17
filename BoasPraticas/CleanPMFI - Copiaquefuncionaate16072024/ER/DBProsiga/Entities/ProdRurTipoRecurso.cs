using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class ProdRurTipoRecurso
{
    public int IdtipoRecurso { get; set; }

    public string? Nome { get; set; }

    public int? Idclassificacao { get; set; }

    public virtual ProdRurClassificacaoRecurso? IdclassificacaoNavigation { get; set; }

    public virtual ICollection<ProdRurRecurPropriedade> ProdRurRecurPropriedades { get; set; } = new List<ProdRurRecurPropriedade>();
}
