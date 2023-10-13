using Domain.Filters;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ViewModels.MegaData
{
    public class MegaData_NFSE_ViewModel
    {
        // [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public long IDMegaData_NFSE { get; set; }
        public DateTime DataGeracao { get; set; }
        public DateTime DataInicioPeriodo { get; set; }
        public DateTime DataFinalPeriodo { get; set; }
        public DateTime? DataEnvio { get; set; }
        public string? NomeArquivo { get; set; }
        public string? CaminhoArquivo { get; set; }
        public MegaData_NFSEFilter? MegaData_NFSEFilter { get; set; }


    }
}
