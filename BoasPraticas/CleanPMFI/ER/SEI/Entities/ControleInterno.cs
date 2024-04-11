using System;
using System.Collections.Generic;

namespace SEI.Entities;

public partial class ControleInterno
{
    public int IdControleInterno { get; set; }

    public string Descricao { get; set; } = null!;

    public virtual ICollection<Acesso> Acessos { get; set; } = new List<Acesso>();

    public virtual ICollection<Orgao> IdOrgaos { get; set; } = new List<Orgao>();

    public virtual ICollection<Serie> IdSeries { get; set; } = new List<Serie>();

    public virtual ICollection<TipoProcedimento> IdTipoProcedimentos { get; set; } = new List<TipoProcedimento>();

    public virtual ICollection<Unidade> IdUnidades { get; set; } = new List<Unidade>();
}
