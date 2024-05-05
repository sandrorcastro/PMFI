using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class LocacaoMoveisEquipamento
{
    public long Idlocacao { get; set; }

    public long? MovEquipId { get; set; }

    public long? CntIdcontrato { get; set; }

    public DateTime? DataInicio { get; set; }

    public DateTime? DataDevolucao { get; set; }

    public virtual DepuContrato? CntIdcontratoNavigation { get; set; }

    public virtual MoveisEquipamento? MovEquip { get; set; }
}
