using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class ManutencaoMoveisEquipamento
{
    public long ManId { get; set; }

    public long ManMovEquipId { get; set; }

    public DateTime ManData { get; set; }

    public string ManDescricao { get; set; } = null!;

    public long ManFornecedorId { get; set; }

    public string? ManSituacao { get; set; }

    public virtual ICollection<DetalhesManutencaoMovEq> DetalhesManutencaoMovEqs { get; set; } = new List<DetalhesManutencaoMovEq>();

    public virtual Contribuinte ManFornecedor { get; set; } = null!;

    public virtual MoveisEquipamento ManMovEquip { get; set; } = null!;
}
