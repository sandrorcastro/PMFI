using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class XMovLogMovEquipamento
{
    public int IdLog { get; set; }

    public DateTime? Data { get; set; }

    public long? MoeMovEquipId { get; set; }

    public string? Descricao { get; set; }

    public long ServId { get; set; }

    public long? AcesMovEquipId { get; set; }
}
