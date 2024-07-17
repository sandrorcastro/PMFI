using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class TribProcArrestoPenhora
    {
        public TribProcArrestoPenhora()
        {
            TribProcArrestoPenhoraDetalhes = new HashSet<TribProcArrestoPenhoraDetalhe>();
            TribProcArrestoPenhoraExecutados = new HashSet<TribProcArrestoPenhoraExecutado>();
            TribProcArrestoPenhoraIntimacaos = new HashSet<TribProcArrestoPenhoraIntimacao>();
        }

        public long ProcArrId { get; set; }
        public long? ProcId { get; set; }
        public string? ProcArrTipo { get; set; }
        public DateTime? DataInclusao { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public string? UsuarioInclusao { get; set; }
        public string? UsuarioAlteracao { get; set; }

        public virtual TribProcProcesso? Proc { get; set; }
        public virtual ICollection<TribProcArrestoPenhoraDetalhe> TribProcArrestoPenhoraDetalhes { get; set; }
        public virtual ICollection<TribProcArrestoPenhoraExecutado> TribProcArrestoPenhoraExecutados { get; set; }
        public virtual ICollection<TribProcArrestoPenhoraIntimacao> TribProcArrestoPenhoraIntimacaos { get; set; }
    }
}
