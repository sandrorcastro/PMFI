using System;
using System.Collections.Generic;

namespace SEI.Entities;

public partial class ImagemFormato
{
    public int IdImagemFormato { get; set; }

    public string Formato { get; set; } = null!;

    public string? Descricao { get; set; }

    public string SinAtivo { get; set; } = null!;
}
