using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class TribTransfDivida
    {
        public TribTransfDivida()
        {
            TribTransfDividasContribuintes = new HashSet<TribTransfDividasContribuinte>();
            TribTransfDividasDestinos = new HashSet<TribTransfDividasDestino>();
            TribTransfDividasOrigems = new HashSet<TribTransfDividasOrigem>();
        }

        public int TransfId { get; set; }
        public long? EdificacaoIddestino { get; set; }
        public long? EmprCmcDestino { get; set; }
        public long? ConIddestino { get; set; }
        public long? EdificacaoIdorigem { get; set; }
        public long? EmprCmcOrigem { get; set; }
        public long? ConIdorigem { get; set; }
        public string Motivo { get; set; } = null!;
        public string? UsuarioInclusao { get; set; }
        public DateTime? DataInclusao { get; set; }

        public virtual Contribuinte? ConIddestinoNavigation { get; set; }
        public virtual Contribuinte? ConIdorigemNavigation { get; set; }
        public virtual TribEdificaco? EdificacaoIddestinoNavigation { get; set; }
        public virtual TribEdificaco? EdificacaoIdorigemNavigation { get; set; }
        public virtual TribEmpresa? EmprCmcDestinoNavigation { get; set; }
        public virtual TribEmpresa? EmprCmcOrigemNavigation { get; set; }
        public virtual ICollection<TribTransfDividasContribuinte> TribTransfDividasContribuintes { get; set; }
        public virtual ICollection<TribTransfDividasDestino> TribTransfDividasDestinos { get; set; }
        public virtual ICollection<TribTransfDividasOrigem> TribTransfDividasOrigems { get; set; }
    }
}
