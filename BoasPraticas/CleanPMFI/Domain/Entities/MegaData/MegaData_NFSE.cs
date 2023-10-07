using Domain.Entities.NFSEDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.MegaData
{
    public class MegaData_NFSE
    {
        

        public DateTime DataGeracao { get; set; }
        public DateTime DataInicioPeriodo { get; set; }
        public DateTime DataFinalPeriodo { get; set; }

        public DateTime? DataEnvio { get; set; }

    }
}
