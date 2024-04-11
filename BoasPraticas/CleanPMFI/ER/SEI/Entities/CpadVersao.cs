using System;
using System.Collections.Generic;

namespace SEI.Entities;

public partial class CpadVersao
{
    public int IdCpadVersao { get; set; }

    public int IdCpad { get; set; }

    public string Sigla { get; set; } = null!;

    public string Descricao { get; set; } = null!;

    public DateTime DthVersao { get; set; }

    public string SinEditavel { get; set; } = null!;

    public string SinAtivo { get; set; } = null!;

    public int? IdUsuario { get; set; }

    public int? IdUnidade { get; set; }

    public virtual ICollection<CpadComposicao> CpadComposicaos { get; set; } = new List<CpadComposicao>();

    public virtual Cpad IdCpadNavigation { get; set; } = null!;

    public virtual Unidade? IdUnidadeNavigation { get; set; }

    public virtual Usuario? IdUsuarioNavigation { get; set; }
}
