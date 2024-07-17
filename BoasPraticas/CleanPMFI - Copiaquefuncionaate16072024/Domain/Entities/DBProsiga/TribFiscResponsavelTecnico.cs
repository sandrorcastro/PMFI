using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TribFiscResponsavelTecnico
    {
        public int RespAuxId { get; set; }
        public long IdcontribCategProf { get; set; }
        public DateTime? RespAuxDataInicio { get; set; }
        public DateTime? RespAuxDataFim { get; set; }
        public long? EmprCmc { get; set; }
        public string? RespAuxTipo { get; set; }
    }
}
