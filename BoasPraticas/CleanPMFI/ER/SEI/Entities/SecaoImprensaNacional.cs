using System;
using System.Collections.Generic;

namespace SEI.Entities;

public partial class SecaoImprensaNacional
{
    public int IdSecaoImprensaNacional { get; set; }

    public int IdVeiculoImprensaNacional { get; set; }

    public string Nome { get; set; } = null!;

    public string? Descricao { get; set; }

    public virtual VeiculoImprensaNacional IdVeiculoImprensaNacionalNavigation { get; set; } = null!;

    public virtual ICollection<PublicacaoLegado> PublicacaoLegados { get; set; } = new List<PublicacaoLegado>();

    public virtual ICollection<Publicacao> Publicacaos { get; set; } = new List<Publicacao>();
}
