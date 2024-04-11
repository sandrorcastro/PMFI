using System;
using System.Collections.Generic;

namespace SEI.Entities;

public partial class Comentario
{
    public int IdComentario { get; set; }

    public long IdProcedimento { get; set; }

    public long? IdRelProtocoloProtocolo { get; set; }

    public int IdUnidade { get; set; }

    public int IdUsuario { get; set; }

    public string Descricao { get; set; } = null!;

    public DateTime DthComentario { get; set; }

    public virtual Procedimento IdProcedimentoNavigation { get; set; } = null!;

    public virtual RelProtocoloProtocolo? IdRelProtocoloProtocoloNavigation { get; set; }

    public virtual Unidade IdUnidadeNavigation { get; set; } = null!;

    public virtual Usuario IdUsuarioNavigation { get; set; } = null!;
}
