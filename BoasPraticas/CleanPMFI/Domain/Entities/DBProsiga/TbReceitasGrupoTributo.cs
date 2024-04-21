using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TbReceitasGrupoTributo
    {
        public string Receita { get; set; } = null!;
        public int TrGrId { get; set; }
    }
}
