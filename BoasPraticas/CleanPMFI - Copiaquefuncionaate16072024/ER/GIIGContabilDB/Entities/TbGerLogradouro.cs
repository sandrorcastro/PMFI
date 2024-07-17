using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbGerLogradouro
{
    public int Idlogradouro { get; set; }

    public string? DsTipo { get; set; }

    public string? NmLogradouro { get; set; }

    public virtual ICollection<TbGerEndereco> TbGerEnderecos { get; set; } = new List<TbGerEndereco>();
}
