using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.NFSEDB
{
    public partial class NfseTblMensagem
    {
        public int Idmensagem { get; set; }
        public string Sttitulo { get; set; } = null!;
        public string? Stmensagem { get; set; }
        public int Idtipomsg { get; set; }
        public DateTime Dtenvio { get; set; }
        public DateTime? Dtrecebimento { get; set; }
        public string Idusuarioenvio { get; set; } = null!;
        public int? Idmensagemref { get; set; }
        public string Idusuariodestino { get; set; } = null!;
        public string? Sttabela { get; set; }
        public string? Stregistro { get; set; }
    }
}
