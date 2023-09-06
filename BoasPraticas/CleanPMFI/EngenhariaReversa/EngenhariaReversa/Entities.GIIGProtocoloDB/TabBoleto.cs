using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGProtocoloDB
{
    public partial class TabBoleto
    {
        public int BoleId { get; set; }
        public long? MoviId { get; set; }
        public byte[]? BoleImage { get; set; }
        public string? BoleObservacao { get; set; }
        public string? BoleNossoNumero { get; set; }
        public DateTime? BoleVencimento { get; set; }
        public DateTime? BoleData { get; set; }
        public decimal? BoleValorBoleto { get; set; }
        public string? BoleSituacao { get; set; }
        public string? BoleSacado { get; set; }
    }
}
