using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class GccQuestionario
    {
        public GccQuestionario()
        {
            GccPergunta = new HashSet<GccPergunta>();
        }

        public string QuestCnpjmembro { get; set; } = null!;
        public int QuestId { get; set; }
        public string? QuestDescr { get; set; }

        public virtual ICollection<GccPergunta> GccPergunta { get; set; }
    }
}
