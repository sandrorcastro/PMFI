using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class HabProblema
    {
        public HabProblema()
        {
            HabProblemasAtendimentos = new HashSet<HabProblemasAtendimento>();
        }

        public int ProblemaId { get; set; }
        public string? ProbDescricao { get; set; }
        public string? ProbObservacao { get; set; }

        public virtual ICollection<HabProblemasAtendimento> HabProblemasAtendimentos { get; set; }
    }
}
