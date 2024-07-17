using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.NFSEDB
{
    public partial class NfseTblNaturezaOperacao
    {
        public byte Idoperacao { get; set; }
        public string Stdescricao { get; set; } = null!;
        public string Stgeraobrigacao { get; set; } = null!;
        public string Stservforamuni { get; set; } = null!;
        public string Stnatopepadrao { get; set; } = null!;
        public string Stnatopeespecial { get; set; } = null!;
        public string Stexigibsuspensa { get; set; } = null!;
    }
}
