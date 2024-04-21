using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class ServCalculoLog
    {
        public long Id { get; set; }
        public long? Iddivida { get; set; }
        public short? Cadastro { get; set; }
        public string? Erro { get; set; }
        public DateTime? Data { get; set; }
    }
}
