using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class SerIturEmpresasSemCmcativ
    {
        public long EmprId { get; set; }
        public string Atividade { get; set; } = null!;
        public string? EmprAtivPrincipal { get; set; }
        public DateTime? EmprAtivDataIni { get; set; }
        public DateTime? EmprAtivDataFim { get; set; }

        public virtual TribAtivAtividade AtividadeNavigation { get; set; } = null!;
        public virtual SerIturEmpresasSemCmc Empr { get; set; } = null!;
    }
}
