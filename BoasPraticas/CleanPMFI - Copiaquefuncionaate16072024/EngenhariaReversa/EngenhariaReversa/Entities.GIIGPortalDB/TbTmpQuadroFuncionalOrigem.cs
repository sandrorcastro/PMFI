using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGPortalDB
{
    public partial class TbTmpQuadroFuncionalOrigem
    {
        public int? IdFonteDados { get; set; }
        public short? IdEmpresa { get; set; }
        public DateTime? DtExecucao { get; set; }
        public string? Nome { get; set; }
        public long? CargaHoraria { get; set; }
        public string? Cargo { get; set; }
        public DateTime? DataAlocacao { get; set; }
        public int? DataDispensa { get; set; }
        public string? FormaInvestidura { get; set; }
        public string? HorarioTrabalho { get; set; }
        public string? LocalLotacao { get; set; }
        public string? TipoSituacao { get; set; }
    }
}
