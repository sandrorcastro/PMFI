using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribTipoParamCalculo
{
    public int TparamId { get; set; }

    public string? TparamNome { get; set; }

    public string? MultiValor { get; set; }

    public string? TptipoCadastro { get; set; }

    /// <summary>
    /// Ordem para multiplicar os fatores nos calculos
    /// </summary>
    public byte OrdemFatorMultiplicacao { get; set; }

    /// <summary>
    /// Ordem para exibição dos fatores nos controles
    /// </summary>
    public byte OrdemVisualizacao { get; set; }

    public string Visualizar { get; set; } = null!;

    public virtual ICollection<TribParamCalculo> TribParamCalculos { get; set; } = new List<TribParamCalculo>();
}
