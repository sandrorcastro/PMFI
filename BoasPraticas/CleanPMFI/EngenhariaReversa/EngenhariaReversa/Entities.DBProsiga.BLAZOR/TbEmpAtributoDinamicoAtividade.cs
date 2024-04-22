using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class TbEmpAtributoDinamicoAtividade
    {
        public string Atividade { get; set; } = null!;
        public int IdAtributo { get; set; }
        public bool? FlAtivo { get; set; }
        public DateTime? DtInclusao { get; set; }
        public string? DsLoginInclusao { get; set; }
    }
}
