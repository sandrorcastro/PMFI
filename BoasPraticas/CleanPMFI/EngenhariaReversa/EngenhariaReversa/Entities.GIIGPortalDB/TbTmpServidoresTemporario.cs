using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGPortalDB
{
    public partial class TbTmpServidoresTemporario
    {
        public int? IdFonteDados { get; set; }
        public short? IdEmpresa { get; set; }
        public DateTime? DtExecucao { get; set; }
        public string? Empresa { get; set; }
        public int? Matricula { get; set; }
        public string? Nome { get; set; }
        public DateTime? Admissao { get; set; }
        public string? CodCargo { get; set; }
        public string? Cargo { get; set; }
        public string? CodLotacao { get; set; }
        public string? Lotacao { get; set; }
        public string? Regime { get; set; }
        public long? CargaHoraria { get; set; }
        public string? Escala { get; set; }
        public string? PrazoContrato { get; set; }
    }
}
