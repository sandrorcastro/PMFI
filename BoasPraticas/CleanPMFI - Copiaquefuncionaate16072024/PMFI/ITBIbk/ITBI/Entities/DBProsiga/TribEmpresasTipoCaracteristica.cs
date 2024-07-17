using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class TribEmpresasTipoCaracteristica
{
    public int EmprCaracId { get; set; }

    public string? EmprCaracNome { get; set; }

    public virtual ICollection<TbConSolicitacaoInscricaoCmc> TbConSolicitacaoInscricaoCmcs { get; set; } = new List<TbConSolicitacaoInscricaoCmc>();

    public virtual ICollection<TribEmpresa> TribEmpresas { get; set; } = new List<TribEmpresa>();
}
