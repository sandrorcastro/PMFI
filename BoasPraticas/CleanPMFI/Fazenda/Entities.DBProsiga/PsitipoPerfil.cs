using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class PsitipoPerfil
{
    public long TipoPerfilId { get; set; }

    public string? TipPerfNome { get; set; }

    public virtual ICollection<Psiformulario> Formularios { get; set; } = new List<Psiformulario>();

    public virtual ICollection<Psiusuario> Usuarios { get; set; } = new List<Psiusuario>();
}
