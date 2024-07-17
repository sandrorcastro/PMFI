using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribAdvertencia
{
    public int AdvertId { get; set; }

    /// <summary>
    /// Código de Identificação do Processo
    /// </summary>
    public long? ProcId { get; set; }

    public string? Motivo { get; set; }

    /// <summary>
    /// Situação da Advertencia: TRAMITE/CONCLUIDO
    /// </summary>
    public string Situacao { get; set; } = null!;

    public string? NumeroDoc { get; set; }

    public int? TipoAdvertId { get; set; }

    public DateTime? Data { get; set; }

    public string? Usuario { get; set; }

    public string? NrProcessoNumAno { get; set; }

    public virtual Processo? Proc { get; set; }

    public virtual TribAdvertenciaTipoOrigem? TipoAdvert { get; set; }

    public virtual ICollection<TribAdvertenciasDivMov> TribAdvertenciasDivMovs { get; set; } = new List<TribAdvertenciasDivMov>();

    public virtual ICollection<TribAdvertenciasDiv> TribAdvertenciasDivs { get; set; } = new List<TribAdvertenciasDiv>();
}
