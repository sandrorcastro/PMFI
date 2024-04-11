using System;
using System.Collections.Generic;

namespace SEI.Entities;

public partial class Participante
{
    public int IdParticipante { get; set; }

    public long IdProtocolo { get; set; }

    public int IdContato { get; set; }

    public int IdUnidade { get; set; }

    public string StaParticipacao { get; set; } = null!;

    public int Sequencia { get; set; }

    public virtual ICollection<AcessoExterno> AcessoExternos { get; set; } = new List<AcessoExterno>();

    public virtual Contato IdContatoNavigation { get; set; } = null!;

    public virtual Protocolo IdProtocoloNavigation { get; set; } = null!;

    public virtual Unidade IdUnidadeNavigation { get; set; } = null!;
}
