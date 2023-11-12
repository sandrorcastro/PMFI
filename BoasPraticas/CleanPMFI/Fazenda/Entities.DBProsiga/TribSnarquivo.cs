using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class TribSnarquivo
{
    /// <summary>
    /// Código de identificação do arquivo de dividas do Simples Nacional.
    /// </summary>
    public int SnarqId { get; set; }

    /// <summary>
    /// Nome do arquivo de importação.
    /// </summary>
    public string? SnarqNome { get; set; }

    /// <summary>
    /// Código da versão do layout utilizado para importação.
    /// </summary>
    public string? SnarqVersao { get; set; }

    /// <summary>
    /// Data de geração do arquivo.
    /// </summary>
    public DateTime? SnarqData { get; set; }

    /// <summary>
    /// Data de inclusão do registro.
    /// </summary>
    public DateTime? SnarqDataInclusao { get; set; }

    /// <summary>
    /// Usuário que inseriu o registro.
    /// </summary>
    public string? SnarqUsuario { get; set; }

    public virtual ICollection<TribSnarquivoDetalhe> TribSnarquivoDetalhes { get; set; } = new List<TribSnarquivoDetalhe>();
}
