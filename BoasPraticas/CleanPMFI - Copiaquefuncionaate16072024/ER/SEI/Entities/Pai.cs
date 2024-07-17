using System;
using System.Collections.Generic;

namespace SEI.Entities;

public partial class Pai
{
    public int IdPais { get; set; }

    public string Nome { get; set; } = null!;

    public virtual ICollection<Cidade> Cidades { get; set; } = new List<Cidade>();

    public virtual ICollection<Contato> ContatoIdPaisNavigations { get; set; } = new List<Contato>();

    public virtual ICollection<Contato> ContatoIdPaisPassaporteNavigations { get; set; } = new List<Contato>();

    public virtual ICollection<Uf> Ufs { get; set; } = new List<Uf>();
}
