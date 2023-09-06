using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGProtocoloDB
{
    public partial class TabLogTransferenciaCadastro
    {
        public int LogId { get; set; }
        public int? OrigemId { get; set; }
        public int? DestinoId { get; set; }
        public string? Tabela { get; set; }
        public string? RegistroOrigem { get; set; }
        public string? RegistroDestino { get; set; }
        public string? TabelasAfetadas { get; set; }
        public string? DeletarOrigem { get; set; }
        public DateTime? DataExclusao { get; set; }
        public string? Usuario { get; set; }
        public string? TransferenciaDe { get; set; }
    }
}
