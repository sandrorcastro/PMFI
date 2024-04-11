using System;
using System.Collections.Generic;

namespace GIIGRepositorioDB.Entities;

public partial class TbRepArq00000002
{
    public long IdArquivo { get; set; }

    public byte[]? BnArquivo { get; set; }

    public string? NmArquivo { get; set; }

    public string? DsExtensao { get; set; }
}
