using System;
using System.Collections.Generic;

namespace SEI.Entities;

public partial class ItemEtapa
{
    public int IdItemEtapa { get; set; }

    public int IdEtapaTrabalho { get; set; }

    public string Nome { get; set; } = null!;

    public string? Descricao { get; set; }

    public int Ordem { get; set; }

    public string SinAtivo { get; set; } = null!;

    public virtual EtapaTrabalho IdEtapaTrabalhoNavigation { get; set; } = null!;

    public virtual ICollection<Documento> IdDocumentos { get; set; } = new List<Documento>();

    public virtual ICollection<Serie> IdSeries { get; set; } = new List<Serie>();

    public virtual ICollection<Unidade> IdUnidades { get; set; } = new List<Unidade>();
}
