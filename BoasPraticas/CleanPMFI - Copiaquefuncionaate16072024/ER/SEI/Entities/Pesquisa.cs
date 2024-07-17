using System;
using System.Collections.Generic;

namespace SEI.Entities;

public partial class Pesquisa
{
    public int IdPesquisa { get; set; }

    public string Nome { get; set; } = null!;

    public int IdUsuario { get; set; }

    public int? IdUnidade { get; set; }

    public virtual ICollection<CampoPesquisa> CampoPesquisas { get; set; } = new List<CampoPesquisa>();

    public virtual Unidade? IdUnidadeNavigation { get; set; }

    public virtual Usuario IdUsuarioNavigation { get; set; } = null!;
}
