using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class Paise
{
    /// <summary>
    /// Código|Código de identificacao do pais
    /// </summary>
    public int PaisId { get; set; }

    /// <summary>
    /// Nome do Pais|Nome do pais
    /// </summary>
    public string? PaisNome { get; set; }

    /// <summary>
    /// Sigla|Sigla de identificação do pais.
    /// </summary>
    public string? PaisSigla { get; set; }

    public virtual ICollection<Cidade> Cidades { get; set; } = new List<Cidade>();
}
