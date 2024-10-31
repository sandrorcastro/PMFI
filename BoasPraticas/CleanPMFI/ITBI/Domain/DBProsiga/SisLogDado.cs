using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class SisLogDado
    {
        public long LoDaId { get; set; }
        public string? BancoNome { get; set; }
        public string? TabelaNome { get; set; }
        public string? TabelaAlias { get; set; }
        /// <summary>
        /// Pode ser: Inclusão, Alteração ou Exclusão.
        /// </summary>
        public string? Operacao { get; set; }
        public string? ObjetoOcorrencia { get; set; }
        public DateTime? DataHora { get; set; }
        public string? Usuario { get; set; }
        public string? EnderecoIp { get; set; }
    }
}
