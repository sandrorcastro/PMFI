using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbGerCategoriasPessoa
{
    public int IdCategoria { get; set; }

    public string? NmCategoria { get; set; }

    public virtual ICollection<TbGerPessoasCategoria> TbGerPessoasCategoria { get; set; } = new List<TbGerPessoasCategoria>();

    public virtual ICollection<TbLicDoctosCrcf> IdDocCrcfs { get; set; } = new List<TbLicDoctosCrcf>();
}
