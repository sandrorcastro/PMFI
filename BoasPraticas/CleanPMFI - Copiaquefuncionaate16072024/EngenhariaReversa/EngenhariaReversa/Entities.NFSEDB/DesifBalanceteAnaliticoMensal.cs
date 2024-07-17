using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.NFSEDB
{
    public partial class DesifBalanceteAnaliticoMensal
    {
        public int Idbalanamen { get; set; }
        public int Iddeclaracao { get; set; }
        public string Stcoddepende { get; set; } = null!;
        public DateTime Dtcompetencia { get; set; }
        public string Idconta { get; set; } = null!;
        public decimal Vlsaldoinicial { get; set; }
        public decimal Vldebito { get; set; }
        public decimal Vlcredito { get; set; }
        public decimal Vlsaldofinal { get; set; }
    }
}
