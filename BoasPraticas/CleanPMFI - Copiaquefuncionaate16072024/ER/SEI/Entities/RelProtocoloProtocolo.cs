using System;
using System.Collections.Generic;

namespace SEI.Entities;

public partial class RelProtocoloProtocolo
{
    public long IdProtocolo1 { get; set; }

    public long IdProtocolo2 { get; set; }

    public int IdUsuario { get; set; }

    public int IdUnidade { get; set; }

    public string StaAssociacao { get; set; } = null!;

    public DateTime DthAssociacao { get; set; }

    public int Sequencia { get; set; }

    public string SinCiencia { get; set; } = null!;

    public long IdRelProtocoloProtocolo { get; set; }

    public virtual ICollection<Comentario> Comentarios { get; set; } = new List<Comentario>();

    public virtual Protocolo IdProtocolo1Navigation { get; set; } = null!;

    public virtual Protocolo IdProtocolo2Navigation { get; set; } = null!;

    public virtual Unidade IdUnidadeNavigation { get; set; } = null!;

    public virtual Usuario IdUsuarioNavigation { get; set; } = null!;
}
