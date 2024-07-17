using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbCtiAssunto
    {
        public TbCtiAssunto()
        {
            TbCtiQuestionarios = new HashSet<TbCtiQuestionario>();
        }

        public int IdAssunto { get; set; }
        public string? DsTitulo { get; set; }
        public string? DsAssunto { get; set; }

        public virtual ICollection<TbCtiQuestionario> TbCtiQuestionarios { get; set; }
    }
}
