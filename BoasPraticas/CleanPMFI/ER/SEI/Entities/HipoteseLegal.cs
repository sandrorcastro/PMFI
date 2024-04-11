using System;
using System.Collections.Generic;

namespace SEI.Entities;

public partial class HipoteseLegal
{
    public int IdHipoteseLegal { get; set; }

    public string Nome { get; set; } = null!;

    public string BaseLegal { get; set; } = null!;

    public string? Descricao { get; set; }

    public string StaNivelAcesso { get; set; } = null!;

    public string SinAtivo { get; set; } = null!;

    public virtual ICollection<Protocolo> Protocolos { get; set; } = new List<Protocolo>();

    public virtual ICollection<TipoProcedimento> TipoProcedimentos { get; set; } = new List<TipoProcedimento>();
}
