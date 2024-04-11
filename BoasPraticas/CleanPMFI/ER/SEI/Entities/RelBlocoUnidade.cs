using System;
using System.Collections.Generic;

namespace SEI.Entities;

public partial class RelBlocoUnidade
{
    public int IdUnidade { get; set; }

    public int IdBloco { get; set; }

    public string SinRetornado { get; set; } = null!;

    public int? IdUsuarioAtribuicao { get; set; }

    public int? IdUsuarioRevisao { get; set; }

    public int? IdUsuarioPrioridade { get; set; }

    public int? IdUsuarioComentario { get; set; }

    public string SinRevisao { get; set; } = null!;

    public string SinPrioridade { get; set; } = null!;

    public string SinComentario { get; set; } = null!;

    public string? TextoComentario { get; set; }

    public DateTime? DthRevisao { get; set; }

    public DateTime? DthPrioridade { get; set; }

    public DateTime? DthComentario { get; set; }

    public int? IdGrupoBloco { get; set; }

    public virtual Bloco IdBlocoNavigation { get; set; } = null!;

    public virtual GrupoBloco? IdGrupoBlocoNavigation { get; set; }

    public virtual Unidade IdUnidadeNavigation { get; set; } = null!;

    public virtual Usuario? IdUsuarioAtribuicaoNavigation { get; set; }

    public virtual Usuario? IdUsuarioComentarioNavigation { get; set; }

    public virtual Usuario? IdUsuarioPrioridadeNavigation { get; set; }

    public virtual Usuario? IdUsuarioRevisaoNavigation { get; set; }
}
