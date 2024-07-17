using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class Loteamento
{
    public int Idloteamento { get; set; }

    public string? Descricao { get; set; }

    public int? Idregiao { get; set; }

    public string? UsuarioInclusao { get; set; }

    public string? Host { get; set; }

    public DateTime? Data { get; set; }

    public virtual ICollection<Fzponto> Fzpontos { get; set; } = new List<Fzponto>();

    public virtual Regio? IdregiaoNavigation { get; set; }

    public virtual ICollection<ImobensImovei> ImobensImoveis { get; set; } = new List<ImobensImovei>();

    public virtual ICollection<Imovei> Imoveis { get; set; } = new List<Imovei>();

    public virtual ICollection<TribAmostraMercado> TribAmostraMercados { get; set; } = new List<TribAmostraMercado>();

    public virtual ICollection<TribEdificaco> TribEdificacos { get; set; } = new List<TribEdificaco>();

    public virtual ICollection<TribQuadraLograd> TribQuadraLograds { get; set; } = new List<TribQuadraLograd>();
}
