﻿using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class TribEmpresasAtiv
    {
        public TribEmpresasAtiv()
        {
            TribEmpresasAtivAtributos = new HashSet<TribEmpresasAtivAtributo>();
        }

        public long EmprCmc { get; set; }
        public string Atividade { get; set; } = null!;
        public string EmprAtivPrincipal { get; set; } = null!;
        public DateTime? EmprAtivDataInI { get; set; }
        public DateTime? EmprAtivDataFim { get; set; }
        public string? EmprAtivObs { get; set; }
        public string EmprAtivProvisorio { get; set; } = null!;
        public string? EmprAtivMotivo { get; set; }

        public virtual TribAtivAtividade AtividadeNavigation { get; set; } = null!;
        public virtual TribEmpresa EmprCmcNavigation { get; set; } = null!;
        public virtual ICollection<TribEmpresasAtivAtributo> TribEmpresasAtivAtributos { get; set; }
    }
}
