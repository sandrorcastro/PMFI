using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class SerIturContribuintesTribEmpresa
    {
        public long ConId { get; set; }
        public long EmprCmc { get; set; }
        public string? UsuId { get; set; }
        public DateTime? Data { get; set; }
    }
}
