using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class TbConSolicitacaoInscricaoSocio
{
    public long IdSolicitacaoInscricaoSocio { get; set; }

    public long? IdSolicitacaoInscricao { get; set; }

    /// <summary>
    /// Superior , Tecnico ou Nenhum
    /// </summary>
    public string? NivelProfissional { get; set; }

    public DateTime? SociosDataIni { get; set; }

    public DateTime? SociosDataFim { get; set; }

    public bool? FlSocio { get; set; }

    public bool? FlPrestaServicos { get; set; }

    /// <summary>
    /// informar se o socio tem domicilio no exterior
    /// </summary>
    public bool? SociosDomicilioExt { get; set; }

    /// <summary>
    /// Garatir nos metodos de inclusao, alteracao e remoção que a tabela mantenha somente um único responsável pela empresa.
    /// </summary>
    public bool? SociosResponsavel { get; set; }

    public string? NrCpf { get; set; }

    public string? NmSocio { get; set; }

    public string? NmConjuge { get; set; }

    public int? TipoSocioId { get; set; }

    public string? DsNomeMae { get; set; }

    public DateTime? DtNascimento { get; set; }

    public long? ConIdMae { get; set; }

    public string? NrRg { get; set; }

    public string? Ufrg { get; set; }

    public virtual TbConSolicitacaoInscricaoCmc? IdSolicitacaoInscricaoNavigation { get; set; }

    public virtual TbTipoSocio? TipoSocio { get; set; }
}
