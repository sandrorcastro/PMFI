using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class TribItbiex
{
    public long Itbiid { get; set; }

    public DateTime? ItbidataLanc { get; set; }

    public string? Itbiobservacao { get; set; }

    public string Itbisituacao { get; set; } = null!;

    public string? Itbiusuario { get; set; }

    public long? Itbiidreal { get; set; }

    public long? ConId { get; set; }

    public string? Itbiip { get; set; }

    public string ItbidsTipo { get; set; } = null!;

    public virtual ICollection<TribAmostraMercadoItbi> TribAmostraMercadoItbis { get; set; } = new List<TribAmostraMercadoItbi>();

    public virtual ICollection<TribItbiexAnexo> TribItbiexAnexos { get; set; } = new List<TribItbiexAnexo>();

    public virtual ICollection<TribItbiexAvaliacao> TribItbiexAvaliacaos { get; set; } = new List<TribItbiexAvaliacao>();

    public virtual ICollection<TribItbiexEdif> TribItbiexEdifs { get; set; } = new List<TribItbiexEdif>();
}
