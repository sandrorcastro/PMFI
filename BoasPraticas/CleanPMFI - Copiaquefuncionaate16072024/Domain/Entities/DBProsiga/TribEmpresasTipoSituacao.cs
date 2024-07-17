using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TribEmpresasTipoSituacao
    {
        public TribEmpresasTipoSituacao()
        {
            TribEmpresas = new HashSet<TribEmpresa>();
            TribEmpresasMovSituacaos = new HashSet<TribEmpresasMovSituacao>();
        }

        public int EmprSituacaoId { get; set; }
        public string? EmprSituacaoDescricao { get; set; }
        public string? EmprSituacaoInicial { get; set; }
        public string EmprSituacaoEmFuncionamento { get; set; } = null!;
        public string EmprSituacaoAltera { get; set; } = null!;
        public string? EmprSituacaoImportar { get; set; }

        public virtual ICollection<TribEmpresa> TribEmpresas { get; set; }
        public virtual ICollection<TribEmpresasMovSituacao> TribEmpresasMovSituacaos { get; set; }
    }
}
