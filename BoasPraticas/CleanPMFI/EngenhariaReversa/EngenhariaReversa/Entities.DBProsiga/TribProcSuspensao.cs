using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class TribProcSuspensao
    {
        public TribProcSuspensao()
        {
            TribProcSuspensaoMotivos = new HashSet<TribProcSuspensaoMotivo>();
        }

        public long ProcSuspId { get; set; }
        public long? ProcId { get; set; }
        public DateTime? ProcSuspDataPeticao { get; set; }
        public DateTime? ProcSuspSuspensoAte { get; set; }
        public string? ProcSuspDeferida { get; set; }
        public DateTime? ProcSuspDataDespacho { get; set; }
        public DateTime? ProcSuspPrazoInicio { get; set; }
        public DateTime? ProcSuspPrazoFim { get; set; }
        public DateTime? DataInclusao { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public string? UsuarioInclusao { get; set; }
        public string? UsuarioAlteracao { get; set; }

        public virtual TribProcProcesso? Proc { get; set; }
        public virtual ICollection<TribProcSuspensaoMotivo> TribProcSuspensaoMotivos { get; set; }
    }
}
