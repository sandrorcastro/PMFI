using System;
using System.Collections.Generic;

namespace SEI.Entities;

public partial class ArquivoExtensao
{
    public int IdArquivoExtensao { get; set; }

    public string Extensao { get; set; } = null!;

    public string? Descricao { get; set; }

    public string SinAtivo { get; set; } = null!;

    public int? TamanhoMaximo { get; set; }

    public string SinInterface { get; set; } = null!;

    public string SinServico { get; set; } = null!;
}
