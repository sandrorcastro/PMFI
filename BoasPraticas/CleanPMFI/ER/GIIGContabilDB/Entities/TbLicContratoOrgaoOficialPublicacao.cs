using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class TbLicContratoOrgaoOficialPublicacao
{
    public int IdContratoPublicacao { get; set; }

    public short? IdEmpresa { get; set; }

    public int? IdPessoa { get; set; }

    public short? IdVeiculoPublicacao { get; set; }

    public int? IdLicitacao { get; set; }

    public DateTime? DtInicio { get; set; }

    public DateTime? DtFinal { get; set; }

    public string? Observacao { get; set; }

    public virtual TbLicLicitaco? IdLicitacaoNavigation { get; set; }

    public virtual TbGerPessoa? IdPessoaNavigation { get; set; }

    public virtual TbLicVeiculosPublicaco? IdVeiculoPublicacaoNavigation { get; set; }
}
