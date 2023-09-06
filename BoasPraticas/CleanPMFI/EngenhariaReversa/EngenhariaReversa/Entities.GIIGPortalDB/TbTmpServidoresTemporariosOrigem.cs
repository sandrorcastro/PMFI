using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGPortalDB
{
    public partial class TbTmpServidoresTemporariosOrigem
    {
        public int IdServTemporario { get; set; }
        public string? CargaHoraria { get; set; }
        public string? Cargo { get; set; }
        public DateTime? DataAlocacao { get; set; }
        public DateTime? DataDispensa { get; set; }
        public string? FormaInvestidura { get; set; }
        public string? HorarioTrabalho { get; set; }
        public string? LocalLotacao { get; set; }
        public string? Nome { get; set; }
    }
}
