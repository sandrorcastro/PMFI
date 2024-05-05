using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class Psiusuario
{
    public long UsuarioId { get; set; }

    public string? UsuarioEmail { get; set; }

    public DateTime? UsuarioDtCad { get; set; }

    public long? UsuarioInclusao { get; set; }

    public long? ConId { get; set; }

    public virtual Contribuinte? Con { get; set; }

    public virtual ICollection<PsitipoPerfil> TipoPerfils { get; set; } = new List<PsitipoPerfil>();
}
