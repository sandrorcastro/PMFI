using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class Edudisciplina
{
    public long DiscId { get; set; }

    public string? DiscNome { get; set; }

    public virtual ICollection<EdudisciplinasTurma> EdudisciplinasTurmas { get; set; } = new List<EdudisciplinasTurma>();

    public virtual ICollection<Edusubstituico> Edusubstituicos { get; set; } = new List<Edusubstituico>();

    public virtual ICollection<Contribuinte> Cons { get; set; } = new List<Contribuinte>();

    public virtual ICollection<Eduserie> Series { get; set; } = new List<Eduserie>();
}
