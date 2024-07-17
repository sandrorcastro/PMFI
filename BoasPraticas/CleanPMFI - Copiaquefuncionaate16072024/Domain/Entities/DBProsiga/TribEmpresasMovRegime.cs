using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TribEmpresasMovRegime
    {
        public long MovRegimeId { get; set; }
        public long? EmprCmc { get; set; }
        public int? EmprRegimeId { get; set; }
        public DateTime? MovRegimeDataAdesao { get; set; }
        public string? UsuarioInclusao { get; set; }
        public DateTime? DataInclusao { get; set; }
    }
}
