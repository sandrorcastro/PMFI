using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class Recebimento
{
    /// <summary>
    /// Código de Identificação do Recebimento
    /// </summary>
    public long RecId { get; set; }

    public long? RecServidorId { get; set; }

    public DateTime? RecData { get; set; }

    public long? RecCargaId { get; set; }

    public string RecSituacao { get; set; } = null!;

    /// <summary>
    /// Numero referente ao recebimento de um determinado lote de documentos
    /// </summary>
    public long RecIdrecebimento { get; set; }

    public virtual CargasProcesso? RecCarga { get; set; }

    public virtual Servidore? RecServidor { get; set; }
}
