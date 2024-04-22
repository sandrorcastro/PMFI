using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class TribProcRecurso
    {
        public TribProcRecurso()
        {
            TribProcRecursosOrigemDets = new HashSet<TribProcRecursosOrigemDet>();
        }

        public long ProcRecId { get; set; }
        public long? ProcId { get; set; }
        public string? ProcRecTipo { get; set; }
        public long? ConId { get; set; }
        public DateTime? DataInclusao { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public string? UsuarioInclusao { get; set; }
        public string? UsuarioAlteracao { get; set; }

        public virtual TribProcProcesso? Proc { get; set; }
        public virtual ICollection<TribProcRecursosOrigemDet> TribProcRecursosOrigemDets { get; set; }
    }
}
