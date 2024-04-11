using System;
using System.Collections.Generic;

namespace SEI.Entities;

public partial class Localizador
{
    public int IdLocalizador { get; set; }

    public int IdUnidade { get; set; }

    public int IdTipoSuporte { get; set; }

    public string? Complemento { get; set; }

    public string StaEstado { get; set; } = null!;

    public int SeqLocalizador { get; set; }

    public int IdTipoLocalizador { get; set; }

    public int IdLugarLocalizador { get; set; }

    public string SinAtivo { get; set; } = null!;

    public virtual ICollection<Arquivamento> Arquivamentos { get; set; } = new List<Arquivamento>();

    public virtual LugarLocalizador IdLugarLocalizadorNavigation { get; set; } = null!;

    public virtual TipoLocalizador IdTipoLocalizadorNavigation { get; set; } = null!;

    public virtual TipoSuporte IdTipoSuporteNavigation { get; set; } = null!;

    public virtual Unidade IdUnidadeNavigation { get; set; } = null!;
}
