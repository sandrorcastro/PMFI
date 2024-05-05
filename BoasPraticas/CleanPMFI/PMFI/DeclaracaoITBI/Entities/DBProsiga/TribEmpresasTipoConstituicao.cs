using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class TribEmpresasTipoConstituicao
{
    public int EmprConstitId { get; set; }

    public string? EmprConstitNome { get; set; }

    /// <summary>
    /// deve ser informado se a empresa se enquadra ou não como micro empresa
    /// </summary>
    public string? EmprConstitEnquadraMe { get; set; }

    /// <summary>
    /// ISS Normal / ISS Autônomo / Nenhum
    /// </summary>
    public string EmprConstitTipoIss { get; set; } = null!;

    public string EmprConstitAutonomo { get; set; } = null!;

    /// <summary>
    /// Parâmetro utilizado para controlar se a empresa pode pagar o ISSQN de acordo com a data de pagamento da nota fiscal no FISS.
    /// </summary>
    public string? EmprConstPublica { get; set; }

    public string? EmprConstitIsento { get; set; }

    public virtual ICollection<TbConSolicitacaoInscricaoCmc> TbConSolicitacaoInscricaoCmcs { get; set; } = new List<TbConSolicitacaoInscricaoCmc>();

    public virtual ICollection<TribEmpresa> TribEmpresas { get; set; } = new List<TribEmpresa>();
}
