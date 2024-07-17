using System;
using System.Collections.Generic;

namespace SEI.Entities;

public partial class Anexo
{
    public int IdAnexo { get; set; }

    public string Nome { get; set; } = null!;

    public long? IdProtocolo { get; set; }

    public string SinAtivo { get; set; } = null!;

    public int IdUnidade { get; set; }

    public int IdUsuario { get; set; }

    public int Tamanho { get; set; }

    public DateTime DthInclusao { get; set; }

    public int? IdBaseConhecimento { get; set; }

    public int? IdProjeto { get; set; }

    public string Hash { get; set; } = null!;

    public virtual BaseConhecimento? IdBaseConhecimentoNavigation { get; set; }

    public virtual Protocolo? IdProtocoloNavigation { get; set; }

    public virtual Unidade IdUnidadeNavigation { get; set; } = null!;

    public virtual Usuario IdUsuarioNavigation { get; set; } = null!;
}
