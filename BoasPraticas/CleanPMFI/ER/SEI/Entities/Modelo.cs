using System;
using System.Collections.Generic;

namespace SEI.Entities;

public partial class Modelo
{
    public int IdModelo { get; set; }

    public string Nome { get; set; } = null!;

    public string SinAtivo { get; set; } = null!;

    public virtual ICollection<SecaoModelo> SecaoModelos { get; set; } = new List<SecaoModelo>();

    public virtual ICollection<Serie> Series { get; set; } = new List<Serie>();
}
