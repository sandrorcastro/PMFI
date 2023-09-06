using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class ManutencaoMoveisEquipamento
    {
        public ManutencaoMoveisEquipamento()
        {
            DetalhesManutencaoMovEqs = new HashSet<DetalhesManutencaoMovEq>();
        }

        public long ManId { get; set; }
        public long ManMovEquipId { get; set; }
        public DateTime ManData { get; set; }
        public string ManDescricao { get; set; } = null!;
        public long ManFornecedorId { get; set; }
        public string? ManSituacao { get; set; }

        public virtual Contribuinte ManFornecedor { get; set; } = null!;
        public virtual MoveisEquipamento ManMovEquip { get; set; } = null!;
        public virtual ICollection<DetalhesManutencaoMovEq> DetalhesManutencaoMovEqs { get; set; }
    }
}
