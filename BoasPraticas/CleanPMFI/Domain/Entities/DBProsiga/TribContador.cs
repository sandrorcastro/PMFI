using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TribContador
    {
        public TribContador()
        {
            FissContribEmpresas = new HashSet<FissContribEmpresa>();
            FissServicos = new HashSet<FissServico>();
            TribEmpresas = new HashSet<TribEmpresa>();
            TribEnquadramentoNotificacaos = new HashSet<TribEnquadramentoNotificacao>();
            TribPortalCaixaEntrada = new HashSet<TribPortalCaixaEntradum>();
        }

        public long ContadorId { get; set; }
        public long ConId { get; set; }
        public string? Crc { get; set; }
        public string? Categoria { get; set; }
        public byte[]? Senha { get; set; }
        /// <summary>
        /// Data da liberação de senha para contador.
        /// </summary>
        public DateTime? DataLibSenha { get; set; }
        /// <summary>
        /// Data de expiração da senha.
        /// </summary>
        public DateTime? DataExpirSenha { get; set; }
        public string SituacaoAcesso { get; set; } = null!;
        /// <summary>
        /// Periodo em dias para expiração do acesso.
        /// </summary>
        public int? PerDiasExpiracao { get; set; }
        public string? DsLogin { get; set; }

        public virtual Contribuinte Con { get; set; } = null!;
        public virtual ICollection<FissContribEmpresa> FissContribEmpresas { get; set; }
        public virtual ICollection<FissServico> FissServicos { get; set; }
        public virtual ICollection<TribEmpresa> TribEmpresas { get; set; }
        public virtual ICollection<TribEnquadramentoNotificacao> TribEnquadramentoNotificacaos { get; set; }
        public virtual ICollection<TribPortalCaixaEntradum> TribPortalCaixaEntrada { get; set; }
    }
}
