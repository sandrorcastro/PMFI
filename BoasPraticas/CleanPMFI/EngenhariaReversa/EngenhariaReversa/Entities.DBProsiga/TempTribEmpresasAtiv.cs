using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class TempTribEmpresasAtiv
    {
        public long EmprCmc { get; set; }
        public string Atividade { get; set; } = null!;
        public string EmprAtivPrincipal { get; set; } = null!;
        public DateTime? EmprAtivDataInI { get; set; }
        public DateTime? EmprAtivDataFim { get; set; }
    }
}
