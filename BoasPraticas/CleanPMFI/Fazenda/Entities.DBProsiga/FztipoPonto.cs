using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class FztipoPonto
{
    /// <summary>
    /// Código de Identificação do Tipo do Ponto
    /// </summary>
    public int FztipoPontoId { get; set; }

    /// <summary>
    /// Descrição do Tipo do Ponto de Veiculo, definido normalmente pelo Tipo do Veículo como MotoTaxi, Taxi, etc. 
    /// </summary>
    public string? FztipoPontoNome { get; set; }

    public virtual ICollection<Fzponto> Fzpontos { get; set; } = new List<Fzponto>();
}
