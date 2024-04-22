using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class EdudisciplinasTurma
    {
        public EdudisciplinasTurma()
        {
            Edusubstituicos = new HashSet<Edusubstituico>();
        }

        public long TurmaId { get; set; }
        public long DiscId { get; set; }
        public long? DadFidsubstituto { get; set; }
        public int? DiscTurmaQtdeHoras { get; set; }
        public long? DadFidtitular { get; set; }

        public virtual RhdadosFuncionai? DadFidsubstitutoNavigation { get; set; }
        public virtual RhdadosFuncionai? DadFidtitularNavigation { get; set; }
        public virtual Edudisciplina Disc { get; set; } = null!;
        public virtual Eduturma Turma { get; set; } = null!;
        public virtual ICollection<Edusubstituico> Edusubstituicos { get; set; }
    }
}
