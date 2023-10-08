using Domain.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ViewModels.MegaData
{
    public class MegaData_NFSE_ViewModel
    {

        public DateTime DataGeracao { get; set; }
        public DateTime DataInicioPeriodo { get; set; }
        public DateTime DataFinalPeriodo { get; set; }
        public DateTime? DataEnvio { get; set; }
        public MegaData_NFSEFilter? MegaData_NFSEFilter { get; set; }

    }
}
