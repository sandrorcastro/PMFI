using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class VwLicitacaoIten
{
    public int? IdLicitacao { get; set; }

    public string? Cnpjempresa { get; set; }

    public int? NrSequencial { get; set; }

    public short? IdModalidade { get; set; }

    public string? NumLicitacao { get; set; }
}
