using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbCtiPergunta
    {
        public TbCtiPergunta()
        {
            TbCtiResposta = new HashSet<TbCtiResposta>();
        }

        public int IdPergunta { get; set; }
        public int IdQuestionario { get; set; }
        public string? DsPergunta { get; set; }

        public virtual TbCtiQuestionario IdQuestionarioNavigation { get; set; } = null!;
        public virtual ICollection<TbCtiResposta> TbCtiResposta { get; set; }
    }
}
