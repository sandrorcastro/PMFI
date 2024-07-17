using System;
using System.Collections.Generic;

namespace ITBI.Entities.DBProsiga;

public partial class RhdadosFuncionai
{
    public long DadFid { get; set; }

    public long? DadPmatricula { get; set; }

    public string? MemCnpj { get; set; }

    public long? VincEid { get; set; }

    public long? CargoFuncId { get; set; }

    public int? DivId { get; set; }

    public int? LocIdlotacao { get; set; }

    public int? LocIdatuacao { get; set; }

    public long? RecIdpadrao { get; set; }

    public long? RecIdatual { get; set; }

    public DateTime? DadFdataAdm { get; set; }

    public DateTime? DadFdataDem { get; set; }

    public long? ConcId { get; set; }

    public int? DadFnotaConcurso { get; set; }

    public int? DadFclassifConcurso { get; set; }

    public int? DadFqtdeVt { get; set; }

    public long? CargoFuncIdatual { get; set; }

    public virtual RhcargosFunco? CargoFunc { get; set; }

    public virtual RhcargosFunco? CargoFuncIdatualNavigation { get; set; }

    public virtual Rhconcurso? Conc { get; set; }

    public virtual Diviso? Div { get; set; }

    public virtual ICollection<EduacoEstagioProbatorio> EduacoEstagioProbatorios { get; set; } = new List<EduacoEstagioProbatorio>();

    public virtual ICollection<EdudisciplinasTurma> EdudisciplinasTurmaDadFidsubstitutoNavigations { get; set; } = new List<EdudisciplinasTurma>();

    public virtual ICollection<EdudisciplinasTurma> EdudisciplinasTurmaDadFidtitularNavigations { get; set; } = new List<EdudisciplinasTurma>();

    public virtual ICollection<Edufrequencium> Edufrequencia { get; set; } = new List<Edufrequencium>();

    public virtual ICollection<EdumovimentoLotacao> EdumovimentoLotacaos { get; set; } = new List<EdumovimentoLotacao>();

    public virtual ICollection<Edusubstituico> Edusubstituicos { get; set; } = new List<Edusubstituico>();

    public virtual Localizacao? LocIdatuacaoNavigation { get; set; }

    public virtual Localizacao? LocIdlotacaoNavigation { get; set; }

    public virtual Edurecurso? RecIdatualNavigation { get; set; }

    public virtual Edurecurso? RecIdpadraoNavigation { get; set; }

    public virtual RhdadosPessoai? RhdadosPessoai { get; set; }

    public virtual ICollection<Rhlicenca> Rhlicencas { get; set; } = new List<Rhlicenca>();

    public virtual RhvinculoEmpregaticio? VincE { get; set; }
}
