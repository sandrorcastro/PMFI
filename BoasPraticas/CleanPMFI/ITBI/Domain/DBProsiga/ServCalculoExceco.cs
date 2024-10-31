using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class ServCalculoExceco
    {
        public int Id { get; set; }
        public long? Iddivida { get; set; }
        public short? Cadastro { get; set; }
        public string? Multa { get; set; }
        public string? Juros { get; set; }
        public string? Correcao { get; set; }
        public string? Mda { get; set; }
    }
}
