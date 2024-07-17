using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TribEmpresasTipoCaracteristica
    {
        public TribEmpresasTipoCaracteristica()
        {
            TbConSolicitacaoInscricaoCmcs = new HashSet<TbConSolicitacaoInscricaoCmc>();
            TribEmpresas = new HashSet<TribEmpresa>();
        }

        public int EmprCaracId { get; set; }
        public string? EmprCaracNome { get; set; }

        public virtual ICollection<TbConSolicitacaoInscricaoCmc> TbConSolicitacaoInscricaoCmcs { get; set; }
        public virtual ICollection<TribEmpresa> TribEmpresas { get; set; }
    }
}
