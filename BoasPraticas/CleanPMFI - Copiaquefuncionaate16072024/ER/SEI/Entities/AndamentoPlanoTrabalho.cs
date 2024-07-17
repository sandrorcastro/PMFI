using System;
using System.Collections.Generic;

namespace SEI.Entities;

public partial class AndamentoPlanoTrabalho
{
    public int IdAndamentoPlanoTrabalho { get; set; }

    public int IdPlanoTrabalho { get; set; }

    public long IdProcedimento { get; set; }

    public int IdTarefaPlanoTrabalho { get; set; }

    public int IdUsuarioOrigem { get; set; }

    public int IdUnidadeOrigem { get; set; }

    public DateTime DthExecucao { get; set; }

    public string? StaSituacao { get; set; }

    public virtual ICollection<AtributoAndamPlanoTrab> AtributoAndamPlanoTrabs { get; set; } = new List<AtributoAndamPlanoTrab>();

    public virtual PlanoTrabalho IdPlanoTrabalhoNavigation { get; set; } = null!;

    public virtual Procedimento IdProcedimentoNavigation { get; set; } = null!;

    public virtual TarefaPlanoTrabalho IdTarefaPlanoTrabalhoNavigation { get; set; } = null!;

    public virtual Unidade IdUnidadeOrigemNavigation { get; set; } = null!;

    public virtual Usuario IdUsuarioOrigemNavigation { get; set; } = null!;
}
