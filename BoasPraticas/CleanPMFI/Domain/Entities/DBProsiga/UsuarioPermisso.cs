using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class UsuarioPermisso
    {
        public string UsuId { get; set; } = null!;
        public bool? FlDividasExerciciosAnteriores { get; set; }
        public bool? FlDividasEmpresa { get; set; }
        public bool? FlDividasImovel { get; set; }
        public bool? FlDividasContribuinte { get; set; }
        public string? DsLoginInclusao { get; set; }
        public DateTime? DtInclusao { get; set; }
        public string? DsLoginAlteracao { get; set; }
        public DateTime? DtUltAlteracao { get; set; }
    }
}
