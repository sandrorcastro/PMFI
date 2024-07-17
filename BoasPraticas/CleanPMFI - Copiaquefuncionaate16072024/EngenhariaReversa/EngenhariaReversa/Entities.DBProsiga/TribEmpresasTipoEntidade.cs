using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class TribEmpresasTipoEntidade
    {
        public TribEmpresasTipoEntidade()
        {
            SerIturEmpresasSemCmcs = new HashSet<SerIturEmpresasSemCmc>();
            TribEmpresas = new HashSet<TribEmpresa>();
        }

        public short EmprTipoEntidadeId { get; set; }
        public string? EmprTipoEntidadeDescricao { get; set; }

        public virtual ICollection<SerIturEmpresasSemCmc> SerIturEmpresasSemCmcs { get; set; }
        public virtual ICollection<TribEmpresa> TribEmpresas { get; set; }
    }
}
