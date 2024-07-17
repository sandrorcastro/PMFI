using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbCtiQuestionario
    {
        public TbCtiQuestionario()
        {
            TbCtiDespachoSetors = new HashSet<TbCtiDespachoSetor>();
            TbCtiPergunta = new HashSet<TbCtiPergunta>();
        }

        public int IdQuestionario { get; set; }
        public int IdAssunto { get; set; }
        public string? DsQuestionario { get; set; }
        public string? DsResultadoEsperado { get; set; }

        public virtual TbCtiAssunto IdAssuntoNavigation { get; set; } = null!;
        public virtual ICollection<TbCtiDespachoSetor> TbCtiDespachoSetors { get; set; }
        public virtual ICollection<TbCtiPergunta> TbCtiPergunta { get; set; }
    }
}
