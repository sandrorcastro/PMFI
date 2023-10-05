using System;
using System.Collections.Generic;

namespace Domain.Entities.NFSEDB
{
    public partial class NfseTblChat
    {
        public int Idchat { get; set; }
        public string Stusuarioremetente { get; set; } = null!;
        public string Stusuariodestino { get; set; } = null!;
        public DateTime Dtenviomsg { get; set; }
        public DateTime? Dtrecebimentomsg { get; set; }
        public string Stmensagem { get; set; } = null!;
    }
}
