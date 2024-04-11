using System;
using System.Collections.Generic;

namespace SEI.Entities;

public partial class Acompanhamento
{
    public int IdAcompanhamento { get; set; }

    public int IdUnidade { get; set; }

    public int? IdGrupoAcompanhamento { get; set; }

    public long IdProtocolo { get; set; }

    public string? Observacao { get; set; }

    public int TipoVisualizacao { get; set; }

    public int IdUsuario { get; set; }

    public DateTime DthAlteracao { get; set; }

    public string? IdxAcompanhamento { get; set; }

    public virtual GrupoAcompanhamento? IdGrupoAcompanhamentoNavigation { get; set; }

    public virtual Protocolo IdProtocoloNavigation { get; set; } = null!;

    public virtual Unidade IdUnidadeNavigation { get; set; } = null!;

    public virtual Usuario IdUsuarioNavigation { get; set; } = null!;
}
