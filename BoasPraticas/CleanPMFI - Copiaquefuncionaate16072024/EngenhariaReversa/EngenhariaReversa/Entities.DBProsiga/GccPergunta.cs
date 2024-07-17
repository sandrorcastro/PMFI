using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class GccPergunta
    {
        public GccPergunta()
        {
            GccResposta = new HashSet<GccResposta>();
        }

        public string PergCnpjmembro { get; set; } = null!;
        public int PergQuestId { get; set; }
        public int PergId { get; set; }
        public string? PergDescricao { get; set; }

        public virtual GccQuestionario Perg { get; set; } = null!;
        public virtual ICollection<GccResposta> GccResposta { get; set; }
    }
}
