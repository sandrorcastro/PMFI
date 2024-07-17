using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class Edusubstituico
    {
        public long SubsId { get; set; }
        public DateTime? SubsData { get; set; }
        public DateTime? SubsDataIni { get; set; }
        public DateTime? SubsDataFim { get; set; }
        public string? SubsMotivo { get; set; }
        public string? SubsTipo { get; set; }
        public long? DadFid { get; set; }
        public long? TurmaId { get; set; }
        public long? DiscId { get; set; }

        public virtual RhdadosFuncionai? DadF { get; set; }
        public virtual Edudisciplina? Disc { get; set; }
        public virtual EdudisciplinasTurma? EdudisciplinasTurma { get; set; }
    }
}
