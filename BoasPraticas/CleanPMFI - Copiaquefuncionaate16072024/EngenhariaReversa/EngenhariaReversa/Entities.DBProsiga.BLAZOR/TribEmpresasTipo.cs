using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class TribEmpresasTipo
    {
        public TribEmpresasTipo()
        {
            SerIturEmpresasSemCmcs = new HashSet<SerIturEmpresasSemCmc>();
            TribEmpresas = new HashSet<TribEmpresa>();
        }

        public int EmprTipoId { get; set; }
        public string? EmprTipoDescricao { get; set; }

        public virtual ICollection<SerIturEmpresasSemCmc> SerIturEmpresasSemCmcs { get; set; }
        public virtual ICollection<TribEmpresa> TribEmpresas { get; set; }
    }
}
