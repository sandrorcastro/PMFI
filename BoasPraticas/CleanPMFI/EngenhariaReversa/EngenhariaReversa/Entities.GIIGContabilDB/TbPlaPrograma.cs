using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbPlaPrograma
    {
        public TbPlaPrograma()
        {
            TbPlaAcoesProgramas = new HashSet<TbPlaAcoesPrograma>();
            TbPlaIndicadoresSimplificados = new HashSet<TbPlaIndicadoresSimplificado>();
            TbPlaProgramaIndicadors = new HashSet<TbPlaProgramaIndicador>();
            TbPlaProgramasMovimentacos = new HashSet<TbPlaProgramasMovimentaco>();
            TbPlaProgramasMovimentos = new HashSet<TbPlaProgramasMovimento>();
            TbPlaProgramasObjetivos = new HashSet<TbPlaProgramasObjetivo>();
            TbPlaProgramasPermissoesOrgaos = new HashSet<TbPlaProgramasPermissoesOrgao>();
            TbPlaProgramasValores = new HashSet<TbPlaProgramasValore>();
        }

        public int IdPrograma { get; set; }
        public short? IdEscopo { get; set; }
        public string? CdPrograma { get; set; }
        public int? IdVersaoCriacao { get; set; }
        public int? IdMovimento { get; set; }
        public string? TpComando { get; set; }
        public decimal? VlLimite { get; set; }
        public int? IdMacroObjetivo { get; set; }

        public virtual TbPlaMacroObjetivo? IdMacroObjetivoNavigation { get; set; }
        public virtual TbPlaVerso? IdVersaoCriacaoNavigation { get; set; }
        public virtual ICollection<TbPlaAcoesPrograma> TbPlaAcoesProgramas { get; set; }
        public virtual ICollection<TbPlaIndicadoresSimplificado> TbPlaIndicadoresSimplificados { get; set; }
        public virtual ICollection<TbPlaProgramaIndicador> TbPlaProgramaIndicadors { get; set; }
        public virtual ICollection<TbPlaProgramasMovimentaco> TbPlaProgramasMovimentacos { get; set; }
        public virtual ICollection<TbPlaProgramasMovimento> TbPlaProgramasMovimentos { get; set; }
        public virtual ICollection<TbPlaProgramasObjetivo> TbPlaProgramasObjetivos { get; set; }
        public virtual ICollection<TbPlaProgramasPermissoesOrgao> TbPlaProgramasPermissoesOrgaos { get; set; }
        public virtual ICollection<TbPlaProgramasValore> TbPlaProgramasValores { get; set; }
    }
}
