using System;
using System.Collections.Generic;

namespace SEI.Entities;

public partial class CampoPesquisa
{
    public int IdCampoPesquisa { get; set; }

    public int Chave { get; set; }

    public string Valor { get; set; } = null!;

    public int IdPesquisa { get; set; }

    public virtual Pesquisa IdPesquisaNavigation { get; set; } = null!;
}
