using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class TribProcExecSentenca
    {
        public long ProcId { get; set; }
        public long ConId { get; set; }
        /// <summary>
        /// [R]PV e [P]recatorio
        /// </summary>
        public string SentTipoPagamento { get; set; } = null!;
        /// <summary>
        /// Se for Precatorio deve selecionar a natureza [P]atriminial ou [A]limentar
        /// </summary>
        public string? SentTipoNatureza { get; set; }
        public string SentNumeroRegistro { get; set; } = null!;
        public DateTime DataInclusao { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public string? UsuarioInclusao { get; set; }
        public string? UsuarioAlteracao { get; set; }

        public virtual TribProcExecutado TribProcExecutado { get; set; } = null!;
    }
}
