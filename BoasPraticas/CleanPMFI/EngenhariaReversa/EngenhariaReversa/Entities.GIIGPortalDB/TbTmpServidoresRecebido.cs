using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGPortalDB
{
    public partial class TbTmpServidoresRecebido
    {
        public int? IdFonteDados { get; set; }
        public short? IdEmpresa { get; set; }
        public DateTime? DtExecucao { get; set; }
        public string? Escala { get; set; }
        public long? CargaHoraria { get; set; }
        public int? Matricula { get; set; }
        public string? Nome { get; set; }
        public string? Cargo { get; set; }
        public DateTime? DataAlocacao { get; set; }
        public int? DataDispensa { get; set; }
        public int? PrazoCessao { get; set; }
        public string? OrgaoDestino { get; set; }
        public DateTime? Datnot { get; set; }
        public short? Tipnot { get; set; }
    }
}
