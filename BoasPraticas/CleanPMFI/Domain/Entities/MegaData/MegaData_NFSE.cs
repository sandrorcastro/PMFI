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
        
        public long IDMegaData_NFSE { get; set; }
        public DateTime DataGeracao { get; set; }
        public DateTime DataInicioPeriodo { get; set; }
        public DateTime DataFinalPeriodo { get; set; }

        public DateTime? DataEnvio { get; set; }
        public string? NomeArquivo { get; set; }
        public string? CaminhoArquivo { get; set; }
        public string? TipoArquivo { get; set; }


    }
}
