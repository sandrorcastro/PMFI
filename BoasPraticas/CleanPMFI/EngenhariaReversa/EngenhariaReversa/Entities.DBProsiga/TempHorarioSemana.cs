using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class TempHorarioSemana
    {
        public int? UltLocacao { get; set; }
        public int? TaxaLocacao { get; set; }
        public int? TotLocacao { get; set; }
        public int? SubLocal { get; set; }
        public int? TipoSubLocal { get; set; }
        public DateTime? DataHor { get; set; }
        public string? NomeSubLocal { get; set; }
        public string? HorIni { get; set; }
        public string? HorFim { get; set; }
        public string? Situacao { get; set; }
        public string? Atividade { get; set; }
    }
}
