using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class TribEmpresasSociosProfissionai
{
    public long EmprCmc { get; set; }

    public long ConId { get; set; }

    /// <summary>
    /// Superior , Tecnico ou Nenhum
    /// </summary>
    public string? NivelProfissional { get; set; }

    public DateTime? SociosDataIni { get; set; }

    public DateTime? SociosDataFim { get; set; }

    public string? Socios { get; set; }

    public string? PrestaServicos { get; set; }

    public string? SociosConjuge { get; set; }

    /// <summary>
    /// informar se o socio tem domicilio no exterior
    /// </summary>
    public string? SociosDomicilioExt { get; set; }

    /// <summary>
    /// Garatir nos metodos de inclusao, alteracao e remoção que a tabela mantenha somente um único responsável pela empresa.
    /// </summary>
    public string? SociosResponsavel { get; set; }

    public int? TipoSocioId { get; set; }

    public string? DsNomeMae { get; set; }

    public DateTime? DtNascimento { get; set; }

    public string? ProtocoloIntegracao { get; set; }

    public decimal? SocioCota { get; set; }

    public DateTime? DtRegistroOrgao { get; set; }

    public virtual Contribuinte Con { get; set; } = null!;

    public virtual TribEmpresa EmprCmcNavigation { get; set; } = null!;
}
