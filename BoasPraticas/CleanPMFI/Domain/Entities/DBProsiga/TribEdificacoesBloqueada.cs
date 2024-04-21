using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TribEdificacoesBloqueada
    {
        public int EdifBloqueioD { get; set; }
        public long EdificacaoId { get; set; }
        public DateTime? EdifBloqueioData { get; set; }
        public string? EdifBloqueioMotivo { get; set; }
        public string? UsuarioInclusao { get; set; }
        public DateTime? DataInclusao { get; set; }
        public string? BloqueioAtivo { get; set; }
        public string? UsuarioDesbloqueio { get; set; }
        public DateTime? DataDesbloqueio { get; set; }

        public virtual TribEdificaco Edificacao { get; set; } = null!;
    }
}
