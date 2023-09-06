using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class AmHodometro
    {
        public int? Idpessoa { get; set; }
        public string? Cdbem { get; set; }
        public string? Nrsequencia { get; set; }
        public short? Mes { get; set; }
        public short? Nrano { get; set; }
        public short? Idtipo { get; set; }
        public decimal? NrMedicaoInicial { get; set; }
        public decimal? NrMedicaoFinal { get; set; }
        public decimal? NrMedicaoDeclarada { get; set; }
        public string? Dsnota { get; set; }
        public string? Campo { get; set; }
    }
}
