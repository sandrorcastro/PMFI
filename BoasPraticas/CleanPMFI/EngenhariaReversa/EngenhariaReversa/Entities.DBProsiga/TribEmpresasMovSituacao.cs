using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class TribEmpresasMovSituacao
    {
        public TribEmpresasMovSituacao()
        {
            TribEmpresasReativaSituacaos = new HashSet<TribEmpresasReativaSituacao>();
        }

        public long MovSitId { get; set; }
        public long EmprCmc { get; set; }
        public DateTime? MovSitData { get; set; }
        public int? EmprSituacaoId { get; set; }
        public string? MovSitMotivo { get; set; }
        /// <summary>
        /// Baixa, Paralização,  Bloqueio,  Cancelado ou em Atividade
        /// </summary>
        public string? MovSitTipo { get; set; }
        public string? MovSitProtocoloAnt { get; set; }
        public string? MovSitObservacao { get; set; }
        public long? MovSitProtocNum { get; set; }
        public int? MovSitProtocAno { get; set; }
        public string? MovSitCnpj { get; set; }
        public string? MovSitRazaoSocial { get; set; }
        public string? UsuarioInclusao { get; set; }

        public virtual TribEmpresa EmprCmcNavigation { get; set; } = null!;
        public virtual TribEmpresasTipoSituacao? EmprSituacao { get; set; }
        public virtual ICollection<TribEmpresasReativaSituacao> TribEmpresasReativaSituacaos { get; set; }
    }
}
