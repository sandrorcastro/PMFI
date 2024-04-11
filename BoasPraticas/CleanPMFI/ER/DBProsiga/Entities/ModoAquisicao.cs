using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class ModoAquisicao
{
    public int ModAid { get; set; }

    public string? ModAnome { get; set; }

    public int? MacodTribunal { get; set; }

    public virtual ICollection<Acessorio> Acessorios { get; set; } = new List<Acessorio>();

    public virtual ICollection<AlmEntrada> AlmEntrada { get; set; } = new List<AlmEntrada>();

    public virtual ICollection<ImobensImovei> ImobensImoveis { get; set; } = new List<ImobensImovei>();
}
