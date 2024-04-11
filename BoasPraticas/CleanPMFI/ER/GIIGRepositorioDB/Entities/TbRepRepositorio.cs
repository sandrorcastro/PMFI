using System;
using System.Collections.Generic;

namespace GIIGRepositorioDB.Entities;

public partial class TbRepRepositorio
{
    public int IdRepositorio { get; set; }

    public string? NrChave { get; set; }

    public string? DsRepositorio { get; set; }

    public string? NmRepositorio { get; set; }

    public virtual ICollection<TbRepDadosArquivo> TbRepDadosArquivos { get; set; } = new List<TbRepDadosArquivo>();
}
