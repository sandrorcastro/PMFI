using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TribEmpresasQuestionarioConsultaPrevium
    {
        public int Idquestionarioconsultaprevia { get; set; }
        public string Nrprotocolo { get; set; } = null!;
        public string Nrperguntajunta { get; set; } = null!;
        public string Dsresposta { get; set; } = null!;
    }
}
