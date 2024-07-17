using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TribEmpresasEnquadramento
    {
        public TribEmpresasEnquadramento()
        {
            TribEnquadramentoNotificacaoEmpresas = new HashSet<TribEnquadramentoNotificacaoEmpresa>();
        }

        public long EnquadrId { get; set; }
        public long EmprCmc { get; set; }
        public short? EnquadrNumero { get; set; }
        public int? FxEnquadrAno { get; set; }
        public decimal? EnquadrRecAnual { get; set; }
        public decimal? EnquadrRecAnualUfm { get; set; }
        /// <summary>
        /// Data informada pelo usuário para enquadramento da micro-empresa.
        /// </summary>
        public DateTime? EnquadrData { get; set; }
        public int? EnquadrProtocAno { get; set; }
        public int? EnquadrProtocNum { get; set; }
        public string? EnquadrDeferimento { get; set; }
        public string? EnquadrMotivo { get; set; }
        public string? UsuarioInclusao { get; set; }
        /// <summary>
        /// Data do cadastro de enquadramento gerada pelo sistema.
        /// </summary>
        public DateTime? DataInclusao { get; set; }
        public int? FxEnquadrFaixa { get; set; }
        public long? TextoId { get; set; }
        public long? ServId { get; set; }
        public DateTime? EnquadrDataBase { get; set; }
        public long? ConId { get; set; }
        public long? ContadorId { get; set; }
        public string? EnderecoIp { get; set; }
        public string? EnquadrCancelado { get; set; }
        public string? EnquadrMotivoCanc { get; set; }

        public virtual TribEmpresa EmprCmcNavigation { get; set; } = null!;
        public virtual ICollection<TribEnquadramentoNotificacaoEmpresa> TribEnquadramentoNotificacaoEmpresas { get; set; }
    }
}
