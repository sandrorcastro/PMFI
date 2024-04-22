using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TribEmpresasTipoRegime
    {
        public int EmprRegimeId { get; set; }
        public string? EmprRegimeNome { get; set; }
        public string? EmprRegimeDescricao { get; set; }
    }
}
