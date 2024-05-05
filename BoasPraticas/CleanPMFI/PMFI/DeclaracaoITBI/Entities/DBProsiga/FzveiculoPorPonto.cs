using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class FzveiculoPorPonto
{
    public long FzveiId { get; set; }

    public long FzpontoId { get; set; }

    /// <summary>
    /// Número de identificação do veículo que é numerado por ponto, com ex.: ponto 1, carro 1, ponto 2, carro 2.
    /// </summary>
    public long VppNumVeiculo { get; set; }

    /// <summary>
    /// Situacao Veiculo(Proprio / Arrendado / Locado / Outros)
    /// </summary>
    public string? VppSitVeiculo { get; set; }

    public virtual Fzponto Fzponto { get; set; } = null!;

    public virtual Fzveiculo Fzvei { get; set; } = null!;
}
