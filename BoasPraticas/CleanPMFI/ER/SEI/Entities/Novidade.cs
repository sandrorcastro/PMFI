using System;
using System.Collections.Generic;

namespace SEI.Entities;

public partial class Novidade
{
    public int IdNovidade { get; set; }

    public int IdUsuario { get; set; }

    public string Titulo { get; set; } = null!;

    public string Descricao { get; set; } = null!;

    public DateTime? DthLiberacao { get; set; }

    public virtual Usuario IdUsuarioNavigation { get; set; } = null!;
}
