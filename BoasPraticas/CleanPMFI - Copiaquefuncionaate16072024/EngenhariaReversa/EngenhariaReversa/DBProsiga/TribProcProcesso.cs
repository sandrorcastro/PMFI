using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TribProcProcesso
    {
        public TribProcProcesso()
        {
            TribProcAdvogados = new HashSet<TribProcAdvogado>();
            TribProcArrestoPenhoras = new HashSet<TribProcArrestoPenhora>();
            TribProcAutors = new HashSet<TribProcAutor>();
            TribProcCda = new HashSet<TribProcCdum>();
            TribProcCitacaos = new HashSet<TribProcCitacao>();
            TribProcEmbargoes = new HashSet<TribProcEmbargo>();
            TribProcExecutados = new HashSet<TribProcExecutado>();
            TribProcInfoComplementars = new HashSet<TribProcInfoComplementar>();
            TribProcPeticaos = new HashSet<TribProcPeticao>();
            TribProcProcuradors = new HashSet<TribProcProcurador>();
            TribProcRecursos = new HashSet<TribProcRecurso>();
            TribProcSuspensaos = new HashSet<TribProcSuspensao>();
            TribProcTestemunhas = new HashSet<TribProcTestemunha>();
        }

        public long ProcId { get; set; }
        public int? ProcNumero { get; set; }
        public int? ProcAno { get; set; }
        public string? ProcVaraCivil { get; set; }
        public string? ProcObs { get; set; }
        public DateTime? ProcData { get; set; }
        public string? ProcMotivoExtincao { get; set; }
        public DateTime? ProcDataExtincao { get; set; }
        public string? ProcSentencaExtincao { get; set; }
        public int? ProcTipoProcId { get; set; }
        public string? ProcNumDistribuicao { get; set; }
        public string? ProcLiberaCalculoHonorario { get; set; }
        public string? ProcNumeroUnico { get; set; }
        public decimal? ProcPercHonorario { get; set; }
        public decimal? ProcValorCausa { get; set; }
        public DateTime? DataInclusao { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public string? UsuarioInclusao { get; set; }
        public string? UsuarioAlteracao { get; set; }
        public int? ProcOrgJurisId { get; set; }

        public virtual TribProcOrgaoJurisdicional? ProcOrgJuris { get; set; }
        public virtual ICollection<TribProcAdvogado> TribProcAdvogados { get; set; }
        public virtual ICollection<TribProcArrestoPenhora> TribProcArrestoPenhoras { get; set; }
        public virtual ICollection<TribProcAutor> TribProcAutors { get; set; }
        public virtual ICollection<TribProcCdum> TribProcCda { get; set; }
        public virtual ICollection<TribProcCitacao> TribProcCitacaos { get; set; }
        public virtual ICollection<TribProcEmbargo> TribProcEmbargoes { get; set; }
        public virtual ICollection<TribProcExecutado> TribProcExecutados { get; set; }
        public virtual ICollection<TribProcInfoComplementar> TribProcInfoComplementars { get; set; }
        public virtual ICollection<TribProcPeticao> TribProcPeticaos { get; set; }
        public virtual ICollection<TribProcProcurador> TribProcProcuradors { get; set; }
        public virtual ICollection<TribProcRecurso> TribProcRecursos { get; set; }
        public virtual ICollection<TribProcSuspensao> TribProcSuspensaos { get; set; }
        public virtual ICollection<TribProcTestemunha> TribProcTestemunhas { get; set; }
    }
}
