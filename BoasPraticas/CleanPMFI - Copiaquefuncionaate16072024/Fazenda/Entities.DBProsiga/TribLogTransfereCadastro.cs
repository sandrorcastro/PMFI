using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class TribLogTransfereCadastro
{
    public int Idlog { get; set; }

    public string? TabelaOrigem { get; set; }

    public string? TabelaDestino { get; set; }

    public string? TabelasAfetadas { get; set; }

    public string? Usuario { get; set; }

    public DateTime? Data { get; set; }

    public string? OrigemExcluida { get; set; }

    public string? TransferenciaDe { get; set; }

    public virtual ICollection<TribLogTransfereCadastrosRegistro> TribLogTransfereCadastrosRegistros { get; set; } = new List<TribLogTransfereCadastrosRegistro>();
}
