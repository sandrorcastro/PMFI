using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGPortalDB
{
    public partial class TbTmpAgentesPublicosPti
    {
        public int? Id { get; set; }
        public int? CargaHoraria { get; set; }
        public string? Cargo { get; set; }
        public DateTime? DataAlocacao { get; set; }
        public DateTime? DataDispensa { get; set; }
        public string? LocalLotacao { get; set; }
        public string? Matricula { get; set; }
        public string? Nome { get; set; }
        public decimal? Remuneracao { get; set; }
        public string? Situacao { get; set; }
        public string? VinculoEmpregaticio { get; set; }
    }
}
