using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class TempLogCdum
    {
        public long LoDaId { get; set; }
        public string? BancoNome { get; set; }
        public string? TabelaNome { get; set; }
        public string? TabelaAlias { get; set; }
        public string? Operacao { get; set; }
        public string? ObjetoOcorrencia { get; set; }
        public DateTime? DataHora { get; set; }
        public string? Usuario { get; set; }
        public string? EnderecoIp { get; set; }
        public long? Iddivida { get; set; }
        public int? Idtipodivida { get; set; }
    }
}
