using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class CnaetribAtivAtividade
    {
        public string Atividade { get; set; } = null!;
        public string? AtividadeDenom { get; set; }
        public string? AtivClasse { get; set; }
        public string? AtividadeAutonomo { get; set; }
        public string? AtividadeCodAntigo { get; set; }
        public string? AtividadeEnquadrMicroEmpr { get; set; }
        public decimal AtividadeUffiacresc { get; set; }
        public int? AtSetId { get; set; }
        public string? AtCnae { get; set; }
        public string? AtRequisitos { get; set; }

        public virtual CnaetribAtivClasse? AtivClasseNavigation { get; set; }
    }
}
