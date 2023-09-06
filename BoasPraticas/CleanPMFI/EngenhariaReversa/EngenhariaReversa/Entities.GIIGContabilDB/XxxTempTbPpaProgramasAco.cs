using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class XxxTempTbPpaProgramasAco
    {
        public int IdAcao { get; set; }
        public short IdEmpresa { get; set; }
        public short NrAnoPpa { get; set; }
        public short NrVersao { get; set; }
        public string? CdOrgao { get; set; }
        public string? CdUnidade { get; set; }
        public string CdFuncao { get; set; } = null!;
        public string CdSubFuncao { get; set; } = null!;
        public string CdPrograma { get; set; } = null!;
        public string CdAcao { get; set; } = null!;
        public string? DsContinuaAnoAnterior { get; set; }
        public string? DsAcao { get; set; }
        public string? DsProduto { get; set; }
        public short? IdUnidadeMedida { get; set; }
        public DateTime? DtInicio { get; set; }
        public DateTime? DtFim { get; set; }
        public string? DsTipo { get; set; }
        public DateTime? DtCancelamento { get; set; }
        public string? DsMotivoCancelamento { get; set; }
        public string? DsTpComando { get; set; }
        public int? IdProjetoAtividade { get; set; }
        public string? DsSigla { get; set; }
        public string? DsTipoAcao { get; set; }
    }
}
