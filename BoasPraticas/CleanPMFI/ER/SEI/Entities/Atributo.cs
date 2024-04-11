using System;
using System.Collections.Generic;

namespace SEI.Entities;

public partial class Atributo
{
    public int IdAtributo { get; set; }

    public int IdTipoFormulario { get; set; }

    public string Nome { get; set; } = null!;

    public string Rotulo { get; set; } = null!;

    public int Ordem { get; set; }

    public string StaTipo { get; set; } = null!;

    public int? Tamanho { get; set; }

    public int? Linhas { get; set; }

    public int? Decimais { get; set; }

    public string? Mascara { get; set; }

    public string? ValorMinimo { get; set; }

    public string? ValorMaximo { get; set; }

    public string? ValorPadrao { get; set; }

    public string SinObrigatorio { get; set; } = null!;

    public string SinAtivo { get; set; } = null!;

    public virtual ICollection<Dominio> Dominios { get; set; } = new List<Dominio>();

    public virtual TipoFormulario IdTipoFormularioNavigation { get; set; } = null!;

    public virtual ICollection<RelProtocoloAtributo> RelProtocoloAtributos { get; set; } = new List<RelProtocoloAtributo>();
}
