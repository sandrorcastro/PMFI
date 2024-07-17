using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbGerBairro
{
    public int Idbairro { get; set; }

    public string? NmBairro { get; set; }

    public virtual ICollection<TbGerEndereco> TbGerEnderecos { get; set; } = new List<TbGerEndereco>();
}
