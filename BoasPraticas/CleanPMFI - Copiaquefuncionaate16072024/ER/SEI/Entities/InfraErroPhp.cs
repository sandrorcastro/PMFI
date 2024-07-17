using System;
using System.Collections.Generic;

namespace SEI.Entities;

public partial class InfraErroPhp
{
    public string IdInfraErroPhp { get; set; } = null!;

    public int StaTipo { get; set; }

    public string Arquivo { get; set; } = null!;

    public int Linha { get; set; }

    public string Erro { get; set; } = null!;

    public DateTime DthCadastro { get; set; }
}
