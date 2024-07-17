using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class TribNotificacaoProcesso
    {
        public long NotifProcessId { get; set; }
        public int? NotifProcessAno { get; set; }
        public long? NotifProcessNumero { get; set; }
        public DateTime? NotifProcessData { get; set; }
        public string? NotifProcesUsuario { get; set; }
        public long? TribTipoBxId { get; set; }
        public long? TextoId { get; set; }
        public string? Inscricoes { get; set; }
        public string? Observacao { get; set; }
        public long? TextoIdcompl { get; set; }
        public int? DivId { get; set; }
        public string? NrProcessoNumAno { get; set; }
    }
}
