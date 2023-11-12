using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class ManutencaoVeiculo
{
    public long ManutencaoId { get; set; }

    public long? ManVeiculoId { get; set; }

    public long? ManVfornecedorId { get; set; }

    public DateTime? ManVdata { get; set; }

    public string? ManVdescricao { get; set; }

    public string? ManVsituacao { get; set; }

    public virtual ICollection<DetalhesManutencao> DetalhesManutencaos { get; set; } = new List<DetalhesManutencao>();

    public virtual Veiculo? ManVeiculo { get; set; }

    public virtual Contribuinte? ManVfornecedor { get; set; }
}
