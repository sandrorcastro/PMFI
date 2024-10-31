using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class MovimentacaoAcessoriosMovEquip
    {
        public long MoacId { get; set; }
        public long AcesMovEquipId { get; set; }
        public long MoeMovEquipIdAnt { get; set; }
        public long MoeMovEquipIdAtual { get; set; }
        public string? MoacMotivo { get; set; }
        public DateTime? MoacData { get; set; }
        public DateTime? MoacDtConfirmacao { get; set; }
        public string? MoacTipoMovEquip { get; set; }
        public string? MoacSituacao { get; set; }
        /// <summary>
        /// Texto de confirmação da movimentação com servidor que confirmou
        /// </summary>
        public string? MoacObs { get; set; }

        public virtual MoveisEquipamento MoeMovEquipIdAntNavigation { get; set; } = null!;
        public virtual MoveisEquipamento MoeMovEquipIdAtualNavigation { get; set; } = null!;
    }
}
