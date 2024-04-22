using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class Eduturma
    {
        public Eduturma()
        {
            EdudisciplinasTurmas = new HashSet<EdudisciplinasTurma>();
            EduturmaMes = new HashSet<EduturmaMe>();
        }

        public long TurmaId { get; set; }
        public string? TurmaNome { get; set; }
        public long? SerieId { get; set; }
        public int? TurmaAno { get; set; }
        public int? TurmaNumVagas { get; set; }
        public int? TurmaNumMatriculados { get; set; }
        public int? TurmaNumFrequencia { get; set; }
        public int? LocId { get; set; }
        public string? TurmaTurno { get; set; }
        public long? RecId { get; set; }

        public virtual Localizacao? Loc { get; set; }
        public virtual Edurecurso? Rec { get; set; }
        public virtual Eduserie? Serie { get; set; }
        public virtual ICollection<EdudisciplinasTurma> EdudisciplinasTurmas { get; set; }
        public virtual ICollection<EduturmaMe> EduturmaMes { get; set; }
    }
}
