using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class Eduserie
{
    public long SerieId { get; set; }

    public string? SerieSerie { get; set; }

    public long? TipoSerId { get; set; }

    public virtual ICollection<Eduturma> Eduturmas { get; set; } = new List<Eduturma>();

    public virtual EdutipoSerie? TipoSer { get; set; }

    public virtual ICollection<Edudisciplina> Discs { get; set; } = new List<Edudisciplina>();
}
