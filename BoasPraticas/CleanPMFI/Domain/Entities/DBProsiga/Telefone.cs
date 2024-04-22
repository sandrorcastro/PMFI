using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class Telefone
    {
        public int Foneid { get; set; }
        public long? Conid { get; set; }
        public string? Numero { get; set; }
    }
}
