using System;
using System.Collections.Generic;

namespace SEI.Entities;

public partial class Dominio
{
    public int IdDominio { get; set; }

    public int IdAtributo { get; set; }

    public string Valor { get; set; } = null!;

    public string Rotulo { get; set; } = null!;

    public int Ordem { get; set; }

    public string SinPadrao { get; set; } = null!;

    public string SinAtivo { get; set; } = null!;

    public virtual Atributo IdAtributoNavigation { get; set; } = null!;
}
