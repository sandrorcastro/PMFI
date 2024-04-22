using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TribEmpresasQuestionario
    {
        public int Idquestionario { get; set; }
        public string Nrprotocolo { get; set; } = null!;
        public string CoIdentificadorPergunta { get; set; } = null!;
        public string Dsresposta { get; set; } = null!;
    }
}
